using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWinApp
{
    public class ToDoController
    {
        ITodoView _todoView;
        IList<ToDoItem> _todoItems;
        ToDoItem _selectedToDoItem;

        public ToDoController(ITodoView todoView, IList<ToDoItem> todoItems)
        {
            _todoView = todoView;
            _todoItems = todoItems;
         _todoView.SetController(this);
        }

        public IList<ToDoItem> ToDoItems
        {
            get { return _todoItems; }
        }

        private void updateToDoViewDetailValues(ToDoItem todoItem)
        {
            _todoView.ToDoItemName = todoItem.ToDoItemName;
            _todoView.ToDoUID = todoItem.ToDoUID;
            _todoView.Category = todoItem.Category;
            _todoView.ToDoStatus = todoItem.ToDoStatus;
            _todoView.EstimateCompletionDate = todoItem.EstimateCompletionDate;
            _todoView.ActualCompletionDate = todoItem.ActualCompletionDate;
        }

        private void updateToDoItemWithViewValues(ToDoItem todoItem) 
        {
            todoItem.ToDoItemName = _todoView.ToDoItemName;
            todoItem.ToDoUID = _todoView.ToDoUID;
            todoItem.Category = _todoView.Category;
            todoItem.ToDoStatus = _todoView.ToDoStatus;
            todoItem.EstimateCompletionDate = _todoView.EstimateCompletionDate;
            todoItem.ActualCompletionDate = _todoView.ActualCompletionDate;
        }

        public void LoadView()
        {
            _todoView.ClearGrid();
            foreach(var item in _todoItems)
            {
                _todoView.AddToDoItemToGrid(item);
            }

            if( _todoItems.Count > 0 )
            {
                _todoView.SetSelectedToDoItemInGrid(_todoItems[0]);
            }
        }

        public void SelectedToDoItemChanged(int selectedToDoItemID)
        {
            foreach (var item in this.ToDoItems)
            {
                if(item.ToDoUID == selectedToDoItemID)
                {
                    _selectedToDoItem = item;
                    updateToDoViewDetailValues(item);
                    _todoView.SetSelectedToDoItemInGrid(item);
                }
            }

        }

        public void AddNewToDoItem()
        {
            _selectedToDoItem = new ToDoItem("", 1, "", 3, DateTime.Now, DateTime.Now);
            this.updateToDoViewDetailValues(_selectedToDoItem);

        }

        public void RemoveToDoItem()
        {
            int id = this._todoView.GetIdOfSelectedToDoInGrid();
            ToDoItem todoItemToRemove = null;

            if(id != 0)
            {
                foreach(var item in this.ToDoItems)
                {
                    if(item.ToDoUID == id)
                    {
                        todoItemToRemove = item;
                        break;
                    }
                }

                if(todoItemToRemove != null)
                {
                    int newSelectedIndex = this._todoItems.IndexOf(todoItemToRemove);
                    this._todoItems.Remove(todoItemToRemove);
                    this._todoView.RemoveToDoItemFromGrid(todoItemToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < _todoItems.Count)
                    {
                        this._todoView.SetSelectedToDoItemInGrid(this._todoItems[newSelectedIndex]);
                    }

                }
            }
        }

        public void Save()
        {
            _selectedToDoItem = new ToDoItem("", 0, "", 0, DateTime.Now, DateTime.Now);
            updateToDoItemWithViewValues(_selectedToDoItem);

            if(!this._todoItems.Any(x => x.ToDoUID == _selectedToDoItem.ToDoUID))
            {
                this._todoItems.Add(_selectedToDoItem);
                this._todoView.AddToDoItemToGrid(_selectedToDoItem);
            }
            else
            {
                this._todoView.UpdateGridWithChangedToDoItem(_selectedToDoItem);
            }

            _todoView.SetSelectedToDoItemInGrid(_selectedToDoItem);

        }
    }
}
