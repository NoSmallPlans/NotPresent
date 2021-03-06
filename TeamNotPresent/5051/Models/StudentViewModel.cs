﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5051.Models
{
    /// <summary>
    /// View Model for the Student Index, this will have the list of the students in it convered to a StudentDisplayViewModel
    /// </summary>
    public class StudentViewModel
    {
        /// <summary>
        /// The student List to return to the View
        /// </summary>
        public List<StudentDisplayViewModel> StudentList = new List<StudentDisplayViewModel>();

        /// <summary>
        /// Default constructor, needed becase of the constructor that takes a List of Student Models
        /// </summary>
        public StudentViewModel() { }

        /// <summary>
        /// Take the data list passed in, and convert each to a new StudentDisplayViewModel item and add that to the StudentList
        /// </summary>
        /// <param name="dataList"></param>
        public StudentViewModel(List<StudentModel> dataList)
        {
            foreach (var item in dataList)
            {
                StudentList.Add(new StudentDisplayViewModel(item));
            }
        }
    }

    /// <summary>
    /// get/set for current studentID, current student points and student owned pin point for map
    /// </summary>
    public class StudentClaimViewModel
    {
        public string StudentId { get; set; }
        public string Points { get; set; }
        public string StudentOwnedPins { get; set; }

    }

    /// <summary>
    /// View Model for the Student Home, this will called the studentModel and have the list of map pin in MapPinLocationModel
    /// </summary>
    public class StudentHomeViewModel
    {
        public StudentModel Student;
        public List<MapPinLocationModel> MapPinLocationsList;

        public StudentHomeViewModel()
        {
            MapPinLocationsList = new List<MapPinLocationModel>();
        }
    }

}