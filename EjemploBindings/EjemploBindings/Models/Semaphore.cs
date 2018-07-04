using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploBindings.Models
{
    #region MyRegion
    public enum SemaphoreState
    {
        Green,
        Yellow,
        Red
    }
    #endregion


    public class Semaphore
    {

        public string Name { get; set; }
        private SemaphoreState _semaphoreState;
        public SemaphoreState SemaphoreState
        {
            get
            {
                return _semaphoreState;
            }
            set
            {
                _semaphoreState = value;
            }
        }
    }
}
