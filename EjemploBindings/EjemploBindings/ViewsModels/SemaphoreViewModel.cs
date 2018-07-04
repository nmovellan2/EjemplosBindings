using EjemploBindings.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjemploBindings.ViewsModels
{


    public class SemaphoreViewModel: BindableObject //using xamarin.forms
    {

        #region Constructores
        public SemaphoreViewModel()
        {
            Semaphore = new Semaphore
            {
                Name = "Semaforo 1",
                SemaphoreState = SemaphoreState.Green
            };
            ChangeStateCommand = new Command(OnChangeState);
        }

        private void OnChangeState(object obj)
        {
            switch (Semaphore.SemaphoreState)
            {
                case SemaphoreState.Green:
                    Semaphore.SemaphoreState = SemaphoreState.Red;
                    break;
                case SemaphoreState.Yellow:
                    Semaphore.SemaphoreState = SemaphoreState.Red;
                    break;
                case SemaphoreState.Red:
                    Semaphore.SemaphoreState = SemaphoreState.Green;
                    break;
                default:
                    break;
            }
        }
        #endregion

        public ICommand ChangeStateCommand { get; set; }
        private Semaphore _semaphore;
        public Semaphore Semaphore {
            get => _semaphore;
            set
            {
                _semaphore = value;
                OnPropertyChanged();
            }
            }
    }
}
