﻿/*
 * Created by SharpDevelop.
 * User: Lars Magnus
 * Date: 30.06.2014
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SubmittedData
{
    /// <summary>
    /// Description of AchievementSystem.
    /// </summary>
    public
        class
        AchievementSystem
    {
        IResults _user;
        IResults _actual;
        List<string> _achievements = new List<string>();
		
        public AchievementSystem(dynamic user, dynamic actual)
        {
            _user = user;
            _actual = actual;
            CheckDoubleRainbow();
        }
		
        void CheckDoubleRainbow()
        {
            for (int i = 0; i < _user.GetStageOne().winners.Length; i++)
            {
                if ((_actual.GetStageOne().winners[i][0].Equals(_user.GetStageOne().winners[i][0]))
                     && (_actual.GetStageOne().winners[i][1].Equals(_user.GetStageOne().winners[i][1])))
                {
                    _achievements.Add("double-rainbow");
                    break;
                }
		                 
            }
        }

        void CheckPerfectGroup()
        {
        }

		public List<string> GetAchievements()
		{
		    return _achievements;
		}
    }
}
