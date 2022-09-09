using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWinApp
{
    /// <summary>
    /// Model of the application
    /// </summary>
    public class ToDoItem
    {
        /// <summary>
        /// Task Name of ToDo Item
        /// </summary>
        private string _todoItemName;
        public string ToDoItemName
        {
            get { return _todoItemName; }
            set { _todoItemName = value; }
        }

        /// <summary>
        /// Unique ID of ToDo Item
        /// </summary>
        private int _todoUID;
        public int ToDoUID
        {
            get { return _todoUID; }
            set { _todoUID = value; }
        }

        /// <summary>
        /// Category of ToDo Item
        /// </summary>
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Current Status of ToDo Item
        /// </summary>
        private int _todostatus;
        public int ToDoStatus
        {
            get { return _todostatus; }
            set { _todostatus = value; }
        }

        /// <summary>
        /// Estimated Completion Date of ToDo Item
        /// </summary>
        private DateTime _estimateCompletionDate;
        public DateTime EstimateCompletionDate
        {
            get { return _estimateCompletionDate; }
            set { _estimateCompletionDate = value; }
        }

        /// <summary>
        /// Actual Completion Date
        /// </summary>
        private DateTime _actualCompletionDate;
        public DateTime ActualCompletionDate
        {
            get { return _actualCompletionDate; }
            set { _actualCompletionDate = value; }
        }

        /// <summary>
        /// Populating the todo item in model
        /// </summary>
        /// <param name="todoName"></param>
        /// <param name="todoUID"></param>
        /// <param name="category"></param>
        /// <param name="todoStatus"></param>
        /// <param name="estimatedCompletion"></param>
        /// <param name="actualCompletion"></param>
        public ToDoItem(string todoName, int todoUID, string category, int todoStatus, DateTime estimatedCompletion, DateTime actualCompletion)
        {
            _todoItemName = todoName;
            _todoUID = todoUID;
            _category = category;
            _todostatus = todoStatus;
            _estimateCompletionDate = estimatedCompletion;
            _actualCompletionDate = actualCompletion;
        }
    }
}
