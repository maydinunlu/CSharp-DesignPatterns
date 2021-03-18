﻿namespace FactoryPattern
{
    public class WindowsFormRenderer : FormRenderer
    {
        public override Form CreateForm()
        {
            return new WindowsForm();
        }
    }
}