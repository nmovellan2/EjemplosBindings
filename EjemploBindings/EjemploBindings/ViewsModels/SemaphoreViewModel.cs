using EjemploBindings.Models;
using System;
using System.Collections.Generic;
using System.Text;
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
        }
        #endregion


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
