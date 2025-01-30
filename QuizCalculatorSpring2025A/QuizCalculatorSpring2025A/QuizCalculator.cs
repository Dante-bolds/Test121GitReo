// Written By Dante
// 1/27/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculatorSpring2025
{
    public class QuizCalculator
    {
        // class variables
        private double quiz1 = -9999.99;
        private double quiz2 = -9999.99;
        private double quiz3 = -9999.99;
        private double quiz4 = -9999.99;
        // private double total = -39999.96;
        // private double average = -9999.99;
        // private string letterGrade = "n/a";

        //gets and sets
        public double Quiz1
        {
            get { return this.quiz1; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz1 = -9999.99;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }

        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz2 = -9999.99;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }
        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz3 = -9999.99;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }

        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz4 = -9999.99;
                }
                else
                {
                    this.quiz4 = value;
                }
            }
        }

        // Methods
        // BEWARE OF MAGIC NUMBERS
        public double CalcTotal()
        {
            double aTotal = 0.0;
            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;
            return aTotal;
        }
        public double CalcAverage()
        {
            double anAverage = 0.0;

            // the 4 is a classic "Magic Number"
            anAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4.0;
            return anAverage;
        }
        public string CalcLetterGrade()
        {
            double anAverage = 0.0;
            string aletterGrade = "n/a";
            anAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;

            if (anAverage >= 0.0 && anAverage < 60.0)
            {
                aletterGrade = "F";
            }
            if (anAverage >= 60.0 && anAverage < 70.0)
            {
                aletterGrade = "D";
            }
            if (anAverage >= 70.0 && anAverage < 90.0)
            {
                aletterGrade = "B";
            }
            if (anAverage >= 90.0 && anAverage < 1000.0)
            {
                aletterGrade = "A";
            }

            return aletterGrade;
        }
    }
}

