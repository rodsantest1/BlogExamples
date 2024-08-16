namespace ModalDialogComponent
{
    public class CounterState
    {
        public int Count { get; set; }
        //public event Action OnChange;

        public void IncrementCount()
        {
            Count++;
            //NotifyStateChanged();
        }

        //private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
