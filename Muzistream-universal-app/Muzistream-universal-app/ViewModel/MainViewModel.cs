﻿using Muzistream.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/*--------------------------------------------------------
 * MainViewModel.cs
 * 
 * Version: 1.0
 * Author: Filipe
 * Created: 23/09/2016 15:15:29
 * 
 * Notes:
 * -------------------------------------------------------*/

namespace Muzistream.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region FIELDS



        #endregion

        #region PROPERTIES

        private string text;
        public string TextYolo
        {
            get { return this.text; }
            set
            {
                this.text = value;
                this.OnPropertyChanged("TextYolo");
            }
        }

        private string first;
        public string FirstName
        {
            get { return this.first; }
            set
            {
                this.first = value;
                this.OnPropertyChanged("FirstName");
            }
        }

        private string last;
        public string LastName
        {
            get { return this.last; }
            set
            {
                this.last = value;
                this.OnPropertyChanged("LastName");
            }
        }

        private string mail;
        public string Email
        {
            get { return this.mail; }
            set
            {
                this.mail = value;
                this.OnPropertyChanged("Email");
            }
        }

        private string password;
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                this.OnPropertyChanged("Password");
            }
        }

        private string confirm_password;
        public string Confirm_Password
        {
            get { return this.confirm_password; }
            set
            {
                this.confirm_password = value;
                this.OnPropertyChanged("Confirm_Passwrd");
            }
        }

        private int day;
        public int Day
        {
            get { return this.day;  }
            set
            {
                this.day = value;
                this.OnPropertyChanged("Day");
            }
        }

        private int month;
        public int Month
        {
            get { return this.month; }
            set
            {
                this.month = value;
                this.OnPropertyChanged("Month");
            }
        }

        private int year;
        public int Year
        {
            get { return this.year; }
            set
            {
                this.year = value;
                this.OnPropertyChanged("Year");
            }
        }

        private bool accept;
        public bool Accept
        {
            get { return this.accept; }
            set
            {
                this.accept = value;
                this.OnPropertyChanged("Accept");
            }
        }

        private string info;
        public string Info
        {
            get { return this.info; }
            set
            {
                this.info = value;
                this.OnPropertyChanged("Info");
            }
        }
        
        private ICommand onButtonClick;
        public ICommand OnButtonClick
        {
            get { return this.onButtonClick; }
            set
            {
                this.onButtonClick = value;
                this.OnPropertyChanged("OnButtonClick");
            }
        }

        #endregion

        #region CONSTRUCTORS

        public MainViewModel()
        {
            this.Info = "";
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Password = "";
            this.Confirm_Password = "";
            this.Day = 1;
            this.Month = 1;
            this.Year = 2000;
            this.Accept = false;

            this.OnButtonClick = new Command(this.OnButtonAction);
        }

        #endregion

        #region METHODS

        private void OnButtonAction(object param)
        {
            bool confirm = this.Password.Equals(this.Confirm_Password);
           
            this.Info = "RES : " + this.FirstName + " " + this.LastName + " " + this.Email + " " + this.Password + " " + this.Confirm_Password + " " +"CONFIRM PASS : " + confirm + " Accept :" + this.Accept + " Day : " + this.Day + " Month : " + this.Month + " Year : " + this.Year;

        }

        #endregion
    }

}
