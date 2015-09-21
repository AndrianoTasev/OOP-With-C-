using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Project
    {
        private string projectName;

        private string projectStartDate;

        private string details;

        private ProjectState projectState;

        public Project(string projectName, string projectStartDate, string details, ProjectState projectState)
        {
            ProjectName = projectName;
            ProjectStartDate = projectStartDate;
            Details = details;
            ProjectState = projectState;

        }


        public ProjectState ProjectState { get; set; }

        public string Details
        {
            get { return details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The project details cannot be empty!");
                }

                details = value;
            }
        }

        public string ProjectStartDate
        {
            get { return projectStartDate; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The project start date cannot be empty!");
                } 

                projectStartDate = value;
            }
        }

        public string ProjectName
        {
            get { return projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The project name cannot be empty!");
                }

                projectName = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format("Project name: {0} \nProject date: {1} \nProject details: {2} \nProject state: {3}",
                       ProjectName, ProjectStartDate, Details, ProjectState);
        }
    }
}
