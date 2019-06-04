using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamLeader : ProductionWorker
    {
        float monthlyBonus;         //Monthly bonus amount
        int requiredTrainingHours;  //Required number of training hours
        int completedTrainingHours; //Completed number of training hours

        /**
         * No-arg Constructor that sets default values to class fields;
         */

        public TeamLeader()
        {
            monthlyBonus = 0.0f;
            requiredTrainingHours = 0;
            completedTrainingHours = 0;
        }

        /**
         * This constructor initializes an object with a name.
         * employee number, hireDate, shift, and pay rate.
         * @param n The TeamLeader's name.
         * @param num The TeamLeader's number.
         * @param sh The TeamLeader's shift.
         * @param rate The TeamLeader's pay rate.
         * @param monBon The TeamLeader's monthly bonus
         * @param reqHours The TeamLeader's required training hours
         * @param comHours The TeamLeader's completed training hours
         */

        public TeamLeader(string n, string num, int sh, decimal rate,
            float monBon, int reqHours, int comHours)
        {
            this.SetName(n);
            this.SetEmployeeNumber(num);
            this.SetShift(sh);
            this.SetPayRate(rate);
            monthlyBonus = monBon;
            requiredTrainingHours = reqHours;
            completedTrainingHours = comHours;
        }

        /**
         * The SetMonthlyBonus method sets the TeamLeader's monthly bonus.
         * @param bonus The TeamLeader's monthly bonus.
         */

        public void SetMonthlyBonus(float bonus)
        {
            monthlyBonus = bonus;
        }

        /**
         * The SetRequiredTrainingHours method sets the TeamLeader's required training hours.
         * @param required The TeamLeader's required training hours.
         */

        public void SetRequiredTrainingHours(int required)
        {
            requiredTrainingHours = required;
        }

        /**
         * The SetMonthlyBonus method sets the TeamLeader's completed training hours.
         * @param completed The TeamLeader's completed training hours.
         */

        public void SetCompletedTrainingHours(int completed)
        {
            completedTrainingHours = completed;
        }

        /**
        * The GetMonthlyBonus method returns the TeamLeader's monthly bonus.
        * @return The TeamLeader's monthly bonus.
        */

        public float GetMonthlyBonus()
        {
            return monthlyBonus;
        }

        /**
        * The GetRequiredTrainingHours method returns the TeamLeader's required training hours.
        * @return The TeamLeader's required training hours.
        */

        public int GetRequiredTrainingHours()
        {
            return requiredTrainingHours;
        }

        /**
        * The GetCompletedTrainingHours method returns the TeamLeader's completed training hours.
        * @return The TeamLeader's completed training hours.
        */

        public int GetCompletedTrainingHours()
        {
            return completedTrainingHours;
        }
    }
}
