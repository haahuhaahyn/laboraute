public class MyClass : INotifyPropertyChanged
{
    private string _myProperty;

    public string MyProperty
    {
        get { return _myProperty; }
        set
        {
            if (value != _myProperty)
            {
                _myProperty = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty"));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);
    }
}
