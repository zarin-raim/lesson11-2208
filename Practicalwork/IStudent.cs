﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicalwork
{
    interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        String GetName();
        String GetFullName();
        Double GetAvgGrade();
    }
}
