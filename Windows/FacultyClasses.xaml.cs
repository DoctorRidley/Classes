﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Classes.Windows {
    /// <summary>
    /// Interaction logic for FacultyClasses.xaml
    /// </summary>
    public partial class FacultyClasses : Window {
        
        public FacultyClasses() : base("Edit Classes", "/faculty-classes") {
            InitializeComponent();
        }
    }
}
