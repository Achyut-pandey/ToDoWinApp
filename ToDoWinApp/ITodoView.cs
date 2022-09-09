using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWinApp
{
    public interface ITodoView
    {
        void SetController(ToDoController controller);
        void ClearGrid();
        void AddToDoItemToGrid(ToDoItem item);
        void RemoveToDoItemFromGrid(ToDoItem item); 
        void UpdateGridWithChangedToDoItem(ToDoItem item);
        int GetIdOfSelectedToDoInGrid();
        void SetSelectedToDoItemInGrid(ToDoItem item);

        string ToDoItemName { get; set; }
        int ToDoUID { get; set; }
        string Category { get; set; }
        int ToDoStatus { get; set; }
        DateTime EstimateCompletionDate { get; set; }
        DateTime ActualCompletionDate { get; set; }
    }
}
