﻿using QuickApp.Generator.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikApp.UI.Controls
{
    public delegate void ModelSelectionChangedHandler(Object sender, ModelSelectionArgs args);
    public delegate void PropertyChangedHandler(Object sender, PropertyChangedArgs args);

    public class UIUpdater
    {
        public event ModelSelectionChangedHandler ModelSelectionChanged;
        public event PropertyChangedHandler PropertyChanged;

        public void FireModelSelectionChangedEvent(Object sender, ModelSelectionArgs args){
            if(ModelSelectionChanged != null){
                ModelSelectionChanged(sender, args);
            }
        }

        public void FirePropertyChangedEvent(Object sender, PropertyChangedArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender, args);
            }
        }
    }

    public enum ModelSelectionType {Model, Property, Root}

    public class ModelSelectionArgs : EventArgs
    {
        public readonly RootDef RootDef;
        public readonly ModelDef ModelDef;
        public readonly PropertyDef PropertyDef;
        public readonly ModelSelectionType SelectionType;

        public ModelSelectionArgs(RootDef rootDef)
        {
            RootDef = rootDef;
            SelectionType = ModelSelectionType.Root;
        }

        public ModelSelectionArgs(ModelDef modelDef)
        {
            ModelDef = modelDef;
            SelectionType = ModelSelectionType.Model;
        }

        public ModelSelectionArgs(PropertyDef propertyDef)
        {
            PropertyDef = propertyDef;
            SelectionType = ModelSelectionType.Property;
        }
    }


    public class PropertyChangedArgs : EventArgs
    {
        public const String NAME = "Name";

        public readonly Object SourceObject;
        public readonly String PropertyName;
        public readonly Object NewValue;

        public PropertyChangedArgs(Object sourceObject, String propertyName, Object newValue)
        {
            SourceObject = sourceObject;
            PropertyName = propertyName;
            NewValue = newValue;
        }
    }
}
