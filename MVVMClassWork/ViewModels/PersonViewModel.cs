using MVVMClassWork.Models;
using System.ComponentModel;

namespace MVVMClassWork.ViewModels
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
		private Person? _person;

        public Person? Person
		{
			get { return _person; }
			set 
			{
				_person = value;
				OnPropertyChanged(nameof(Person));
			}
		}
		public PersonViewModel() => Person = new Person();    

		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
