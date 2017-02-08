using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CustomTimer
{

	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "CustomTimer: Welcome!";
			Information.Text = "Welcome to CustomTimer!  " +
				"Type a time either using colons (1:15:30) or with "+
				"English time units (any of \u201Cdays,\u201D "+
				"\u201Chours,\u201D \u201Cminutes,\u201D "+
				"\u201Cseconds,\u201D and their abbreviations) " +
				"and then click \u201CStart.\u201D";
		}

		private int secondsElapsed = 0;
		private int secondsRemaining = 0;
		private int secondsCountdownSetTo = 0;

		/*private void ResetMultiButton()
		{
			BtnMulti.Text = "Start";
		}

		public void DisableButton(Button button)
		{
			button.Text = "Timing!";
			button.Enabled = false;
		}*/

		private void BtnMulti_Click(object sender, EventArgs e)
		{
			this.Text = "CustomTimer"; //Clear the "Welcome" from title bar
			if (SecondTimer.Enabled || BtnMulti.Text == "Resume")
			{
				PauseTimer(); //Pause or un-pause
			}
			else
			{
				//Set timer to proper duration, etc.
				//We will take the user's input string and extract the
				//desired timer length from this.

				//Define vars
				int totalSeconds = 0;  //Total seconds to countdown; sum of days, hours, min, sec.
				TimeUnits timeUnits = new TimeUnits(); //Will fill from user input
				String duration = CboDuration.Text; //The user's time string (e.g. 5:00)
				Match match = Regex.Match("d", "c"); //initialize to unsuccessful

				//Define possible input formats (using regular expresssions and named groups)
				String[] patterns = {
                  @"^\s*((((?<hours>\d{1,4})\s*:\s*)?(?<minutes>[012345]?\d)\s*)?:\s*)?(?<seconds>[012345]?\d)\s*$",
                  @"^((?<days>[0123]?\d{1,2})\s*(d|days?)\s*,?\s*(and\s*)?)?((?<hours>[012345]?\d)\s*(h|hrs?|hours?)\s*,?\s*(and\s*)?)?((?<minutes>[012345]?\d)\s*(m|mins?|minutes?)\s*,?\s*(and\s*)?)?((?<seconds>[012345]?\d)\s*(s|secs?|seconds?))?\s*$"
                };

				//figure out user input
				foreach (String pattern in patterns)
				{
					match = Regex.Match(duration, pattern, RegexOptions.IgnoreCase);
					if (match.Success) break;
				}

				if (match.Success)
				{
					if (match.Groups["seconds"].Success)
					{
						timeUnits.Seconds = Int32.Parse(match.Groups["seconds"].Value);
					}
					if (match.Groups["minutes"].Success)
					{
						timeUnits.Minutes = Int16.Parse(match.Groups["minutes"].Value);
					}
					if (match.Groups["hours"].Success)
					{
						timeUnits.Hours = Int16.Parse(match.Groups["hours"].Value);
					}
					if (match.Groups["days"].Success)
					{
						timeUnits.Days = Int16.Parse(match.Groups["days"].Value);
					}

					//Clear out any data from a previous run
					ResetTimer();

					//calculate total seconds runtime
					totalSeconds = TimeHandler.ConvertTimeUnitsToSeconds(timeUnits);

					//avoid zero-length intervals
					if (totalSeconds < 1)
					{
						totalSeconds = 60; //one minute
						timeUnits.Minutes = 1; 
						//because we simultaneously have this value in seconds and TU form
					}

					//Set the counter variables to starting position
					secondsCountdownSetTo = totalSeconds;
					secondsRemaining = secondsCountdownSetTo;

					//Update UI to reflect changes
					Information.Text = "Timer has been set to " + 
						TimeHandler.FormatTime(timeUnits, true) +
						".  \nTimer started.";
					UpdateCounterDisplays();

					//Start Timer
					StartTimer();
				}
				else
				{
					MessageBox.Show("Unfortunately, you did not enter a recognizeable "
						+ "length of time, or else entered a time longer than the maximum "
						+ "(9999 hours, 59 minutes, and 59 seconds).");
				}

			}
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			Information.Text = "Timer stopped with " +
				TimeHandler.FormatTime(secondsElapsed) + " elapsed and " +
				TimeHandler.FormatTime(secondsRemaining) + " remaining.";
			StopTimer();
			ResetTimer();
		}

		
		private void SecondTimer_Tick(object sender, EventArgs e)
		{
			//Update internal counters
			secondsElapsed++;
			secondsRemaining = secondsCountdownSetTo - secondsElapsed;

			//Update UI
			UpdateCounterDisplays();
			int setTo = secondsElapsed * 100 / secondsCountdownSetTo;
			while (setTo > 100) //handle looping
			{
				setTo -= 100;
			}
			PBar.Value = setTo;

			//Check for the timer being finished
			if (secondsCountdownSetTo == secondsElapsed)
			{
				if (ChkLoop.Checked) //restarting loop
				{
					//TimeLeftGroup.Enabled = false;
					if (ChkNotifiy.Checked)
					{
						notifyIcon1.BalloonTipTitle = "Starting Over";
						notifyIcon1.BalloonTipText = "The requested duration has passed." +
								"  The timer will start over again, because it is in \u201CLoop\u201D mode." +
								" \n(To disable these alerts, uncheck \u201CAlert me "+
								"from the notification area.\u201D)";
						notifyIcon1.ShowBalloonTip(8000);
					}
					//Reset seconds elapsed counter
					secondsElapsed = 0;
				}
				else //ending
				{
					//Write message to top of window
					Information.Text = "Countdown complete! Finished after " +
						TimeHandler.FormatTime(secondsElapsed);

					//Stop counting
					StopTimer();

					//Show window if hidden
					this.Show();

					//Alert if user desires
					if (ChkNotifiy.Checked)
					{
						notifyIcon1.BalloonTipTitle = "Time\u2019s Up!";
						notifyIcon1.BalloonTipText = "The timer has finished the countdown from "+
							TimeHandler.FormatTime(secondsCountdownSetTo,true) +".";
						notifyIcon1.ShowBalloonTip(240000);
					}
				}
			}
			notifyIcon1.Text = "CustomTimer \n" + PBar.Value + "% of "  + TimeHandler.FormatTime(secondsCountdownSetTo)
             + "\n" + TimeHandler.FormatTime(secondsElapsed) + " elapsed"
						 + "\n" + TimeHandler.FormatTime(secondsRemaining) + " remaining";
		}

		private void StartTimer()
		{
			BtnMulti.Text = "Pause";
			PBar.Value = 0;
			//TheTimer.Enabled = true;
			BtnReset.Enabled = true;
			SecondTimer.Enabled = true;

			CboDuration.Enabled = false;
			TimeLeftGroup.Enabled = true;
			ElapsedTimeGroup.Enabled = true;
			TotalTimeGroup.Enabled = true;
		}

		private void StopTimer()
		{
			SecondTimer.Enabled = false;
			BtnMulti.Text = "Start";
			BtnReset.Enabled = false;
			//
			CboDuration.Enabled = true;
			//TimeLeftGroup.Enabled = false;
			//ElapsedTimeGroup.Enabled = false;
			//TotalTimeGroup.Enabled = false;
		}

		private void ResetTimer()
		{
			PBar.Value = 0;
			secondsCountdownSetTo = 0;
			secondsElapsed = 0;
			secondsRemaining = 0;
			UpdateCounterDisplays();
		}
		private void PauseTimer()
		{
			if (SecondTimer.Enabled)
			{
				SecondTimer.Enabled = false;
				BtnMulti.Text = "Resume";
			} 
			else 
			{
				SecondTimer.Enabled = true;
				BtnMulti.Text = "Pause";
			}
		}

		private void UpdateCounterDisplays()
		{
			if (secondsRemaining >= 0)
			{
				TimeUnits remaining = TimeHandler.ConvertSecondsToTimeUnits(secondsRemaining);
				String secRemaining = remaining.Seconds.ToString();
				LblSeconds.Text = secRemaining.PadLeft(2, '0');
				String minRemaining = remaining.Minutes.ToString();
				LblMinutes.Text = minRemaining.PadLeft(2, '0');
				LblHours.Text = remaining.Hours.ToString();
				LblDays.Text = remaining.Days.ToString();
			}
			else
			{
				LblSeconds.Text = "00";
				LblMinutes.Text = "00";
				LblHours.Text = "0";
				LblDays.Text = "0";
			}

			LblElapsed.Text = TimeHandler.FormatTime(secondsElapsed);

			LblTotal.Text = TimeHandler.FormatTime(secondsCountdownSetTo);
		}

		private void label1_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("CustomTimer version "+Application.ProductVersion+" is the work of Alan J. Hogan. \n\n"
					+ "CustomTimer is freeware.  You may redistribute it to anyone, under these terms: \n"
					+ "\t1. You may only charge small cost-of-distribution fees. \n\t    This "
					+ "should not be more than $1 online or $5 shipped on disc.\n"
					+ "\t2. You may not purport to have written this program.  \n\t    Clearly indicate it is my work. \n"
					+ "\t3. You may under no circumstances bundle this program with \u201Cspyware,\u201D \n\t    "
					+ "\u201Cadware,\u201D or other software commonly perceived as malicious or unethical. \n\n"
					+ "The program icon was a free download from www.icongalore.com. \n\n"
					+ "I this program is useful for you!  Any comments, questions, bugs, suggestions, donations, or hate mail "
					+ "can be sent to CustomTimer@AlanJHogan.com.  I\u2019d love to hear from you."
					, "About CustomTimer v"+Application.ProductVersion,MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		//Following are all the happy little methods used for the 
		//notification icon and showing/hiding the form.

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void hideCustomTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToggleVisibility();
		}

		private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
		{
			this.Show();
			this.BringToFront();
		}

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			ToggleVisibility();
		}

		private void MainWindow_VisibleChanged(object sender, EventArgs e)
		{
			MenuItemToggleVisible.Text = (this.Visible ? "&Hide Program Window" : "S&how Program Window");
			if (this.Visible)
				this.BringToFront();
		}
		private void ToggleVisibility()
		{
			if (this.Visible == false) this.Show();
			else this.Hide();
		}

	}

	/// <summary>
	/// TimeUnits structs are simply a container used to represent durations of time.
	/// They contain Seconds, Minutes, Hours, and Days values.
	/// These values are not all representing the same duration, but rather
	/// the respective parts of the same duration.  So if Mintues is set to 1,
	/// this does not mean Seconds is 60.  It means, whatever the hours, days, and
	/// seconds are set to, there is also one minute to add to the duration.
	/// Also, being a struct and not a class, there is nothing to check that Minutes
	/// is less than 60.  If you want to ensure this is the case, it is suggested
	/// to take your TimeUnits struct and pass it to TimeHandler.EnsureProperTimeValues().
	/// This will, for example, effectually turn a Minutes value of 77 into one of 17 and increase
	/// Hours by one.
	/// </summary>
	public struct TimeUnits
	{
		public int Seconds;
		public int Minutes;
		public int Hours;
		public int Days;
	}

	/// <summary>
	/// Non-instantiating class used to convert time durations
	/// between seconds, TimeUnits structs, and strings.
	/// </summary>
	public class TimeHandler
	{
		/// <summary>
		/// Takes a TimeUnits struct and enforces seconds and minutes being less
		/// than 60 and hours being less than 24, and increases the higher units to
		/// compensate.  This will, for example, effectually turn a Minutes 
		/// value of 77 into one of 17 and increase Hours by 1.
		/// </summary>
		/// <param name="timeUnits">TimeUnits struct to enforce proper time notation upon</param>
		/// <returns>TimeUnits, with proper values for each member</returns>
		public static TimeUnits EnsureProperTimeValues(TimeUnits timeUnits)
		{
			return ConvertSecondsToTimeUnits(ConvertTimeUnitsToSeconds(timeUnits));
		}

		/// <summary>
		/// Takes a seconds value and returns the TimeUnits struct of equivalent duration.
		/// </summary>
		/// <param name="seconds">Integer number of seconds input</param>
		/// <returns>The TimeUnits struct representing the time length specified in seconds</returns>
		public static TimeUnits ConvertSecondsToTimeUnits(int seconds)
		{
			TimeUnits timeUnits = new TimeUnits();

			timeUnits.Days = (int)Math.Floor((double)seconds / (3600 * 24));
			seconds -= timeUnits.Days * 3600 * 24;
			timeUnits.Hours = (int)Math.Floor((double)seconds / 3600);
			seconds -= timeUnits.Hours * 3600;
			timeUnits.Minutes = (int)Math.Floor((double)seconds / 60);
			seconds -= timeUnits.Minutes * 60;
			timeUnits.Seconds = seconds;

			return timeUnits;
		}

		/// <summary>
		/// The opposite of ConvertSecondsToTimeUnits, this method returns the
		/// duration of a TimeUnits struct in seconds.
		/// </summary>
		/// <param name="timeUnits">TimeUnits struct</param>
		/// <returns>Integer seconds value of input struct</returns>
		public static int ConvertTimeUnitsToSeconds(TimeUnits timeUnits)
		{
			int totalSeconds;

			totalSeconds = timeUnits.Seconds;
			totalSeconds += timeUnits.Minutes * 60;
			totalSeconds += timeUnits.Hours * 3600;
			totalSeconds += timeUnits.Days * 3600 * 24;

			return totalSeconds;
		}

		/// <summary>
		/// Takes a TimeUnits struct argument, or an integer number of seconds,
		/// and returns an easily human-readable
		/// string representation of the duration indicated in the argument.
		/// Does not check that, for example, TimeUnits.Minutes is less than 60.
		/// Does not split days apart from hours even when greater than 24, unless
		/// the optional boolean second argument showDaysSeparateFromHours is TRUE.
		/// </summary>
		/// <param name="timeUnits">Properly split time units as a TimeUnits struct</param>
		/// <returns>String of easily human-readable time units of form 0:00:00</returns>
		public static string FormatTime(TimeUnits timeUnits)
		{
			return FormatTime(timeUnits, false);
		}
		public static string FormatTime(TimeUnits timeUnits, bool showDaysSeparateFromHours)
		{
			string formatted = "";
			string temp = "";

			//Days (if needed)
			if (timeUnits.Days > 0) 
			{
				if (showDaysSeparateFromHours)
				{
					formatted = "" + timeUnits.Days + " days ";
				}
				else 
				{ 
					timeUnits.Hours += timeUnits.Days * 24; 
				}
			}

			//Hours
			formatted += timeUnits.Hours.ToString() + ":";

			//Minutes
			temp = timeUnits.Minutes.ToString();
			formatted += temp.PadLeft(2, '0') + ":";

			//Seconds
			temp = timeUnits.Seconds.ToString();
			formatted += temp.PadLeft(2, '0');

			return formatted;
		}
		public static string FormatTime(int seconds, bool showDaysSeparateFromHours)
		{
			return FormatTime(ConvertSecondsToTimeUnits(seconds), showDaysSeparateFromHours);
		}
		public static string FormatTime(int seconds)
		{
			return FormatTime(ConvertSecondsToTimeUnits(seconds));
		}
	}
}