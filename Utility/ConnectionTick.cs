using classbook.Connection;
using iSlavici.Connection.Models.db;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Timers;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using Timer = System.Timers.Timer;

namespace iSlavici.Utility
{
    internal class ConnectionTick
    {
        /// <summary>
        /// Represents the instance of the timer
        /// </summary>
        private readonly Timer _connection_timer = new Timer();
        /// <summary>
        /// Represents the interval of that timer
        /// </summary>
        private readonly int _interval = 1000;
        /// <summary>
        /// Represents the status label picture, if exist on the form
        /// </summary>
        private readonly Label _status_label = new Label();

        public ConnectionTick(Label lblStatus)
        {
            _status_label = lblStatus;
            _connection_timer = new Timer(_interval);
            _connection_timer.Elapsed += Connection_Timer_Elapsed;
        }

        /// <summary>
        /// Timer method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                /// IF CONNECT SUCCED, THEN SET TO TRUE BOOLEAN VARIABLE AND
                /// SET THE DBCONTEXT AND STATUS LABEL IF NOT NULL
                if (DataAccess.TryConnection())
                {
                    if (_status_label != null) _status_label.Image = Properties.Resources.online_24px;
                    DataAccess._isConnection = true;
                    DataAccess._dbContext = new SlaviciContext();
                }
                else
                {
                    /// IS ALREADY CONNECTED AND NOW ITS THIS IS FALSE
                    /// IT MEANS I HAD CONNECTION AND NOW ITS LOST
                    if (DataAccess._isConnection)
                    {
                        _connection_timer.Stop();
                        DataAccess._isConnection = false;
                        DataAccess._dbContext = null;
                        MessageBox.Show("Server connection failed!\nThe application will close", "Connection lost", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Environment.Exit(0);
                    }

                    if (_status_label != null) _status_label.Image = Properties.Resources.offline_24px;
                    DataAccess._isConnection = false;
                    DataAccess._dbContext = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection_Timer_Elapsed_Login Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopTimer();
                throw ex;
            }
        }
        public void StartTimer()
        {
            _connection_timer.Start();
        }

        public void StopTimer()
        {
            _connection_timer?.Stop();
        }



    }
}