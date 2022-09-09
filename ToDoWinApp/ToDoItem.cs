using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWinApp
{
    public class ToDoItem
    {
        private string _todoItemName;
        public string ToDoItemName
        {
            get { return _todoItemName; }
            set { _todoItemName = value; }
        }

        private int _todoUID;
        public int ToDoUID
        {
            get { return _todoUID; }
            set { _todoUID = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _todostatus;
        public int ToDoStatus
        {
            get { return _todostatus; }
            set { _todostatus = value; }
        }

        private DateTime _estimateCompletionDate;
        public DateTime EstimateCompletionDate
        {
            get { return _estimateCompletionDate; }
            set { _estimateCompletionDate = value; }
        }

        private DateTime _actualCompletionDate;
        public DateTime ActualCompletionDate
        {
            get { return _actualCompletionDate; }
            set { _actualCompletionDate = value; }
        }

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
