using System;
namespace capstonetasklist
{
    public class TaskClass
    {
        #region fields
        private string name;
        private string description;
        private string dueDate;
        private bool complete;
        #endregion

        #region properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }
        #endregion

        #region constructors
        public TaskClass() { }

        public TaskClass(string Name, string Description, string DueDate, bool Complete)
        {
            name = Name;
            description = Description;
            dueDate = DueDate;
            complete = Complete;
        }
        #endregion

        public void PrintTask()
        {
            if (complete == false)
            {
                Console.WriteLine($"{Name} has to {Description}, which is due on {DueDate}, and has not been completed.");
            }
            else
            {
                Console.WriteLine($"{Name} has to {Description}, which was due on {DueDate}, and is marked complete.");
            }
        }
    }
}
