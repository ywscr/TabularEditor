// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for Model
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class Model: TabularNamedObject
			, IDescriptionObject
			, IAnnotationObject
			, ITranslatableObject
	{
	    protected internal new TOM.Model MetadataObject { get { return base.MetadataObject as TOM.Model; } internal set { base.MetadataObject = value; } }

        /// <summary>
        /// Gets or sets the HasLocalChanges of the Model.
        /// </summary>
		[DisplayName("Has Local Changes")]
		[Category("Other"),IntelliSense("The Has Local Changes of this Model.")]
		public bool HasLocalChanges {
			get {
			    return MetadataObject.HasLocalChanges;
			}
			
		}
		private bool ShouldSerializeHasLocalChanges() { return false; }
		public string GetAnnotation(string name) {
		    return MetadataObject.Annotations.Find(name)?.Value;
		}
		public void SetAnnotation(string name, string value, bool undoable = true) {
			if(MetadataObject.Annotations.Contains(name)) {
				MetadataObject.Annotations[name].Value = value;
			} else {
				MetadataObject.Annotations.Add(new TOM.Annotation{ Name = name, Value = value });
			}
			if (undoable) Handler.UndoManager.Add(new UndoAnnotationAction(this, name, value));
		}
		        /// <summary>
        /// Gets or sets the Description of the Model.
        /// </summary>
		[DisplayName("Description")]
		[Category("Basic"),IntelliSense("The Description of this Model.")]
		public string Description {
			get {
			    return MetadataObject.Description;
			}
			set {
				var oldValue = Description;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Description", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Description = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Description", oldValue, value));
				OnPropertyChanged("Description", oldValue, value);
			}
		}
		private bool ShouldSerializeDescription() { return false; }
        /// <summary>
        /// Gets or sets the StorageLocation of the Model.
        /// </summary>
		[DisplayName("Storage Location")]
		[Category("Other"),IntelliSense("The Storage Location of this Model.")]
		public string StorageLocation {
			get {
			    return MetadataObject.StorageLocation;
			}
			set {
				var oldValue = StorageLocation;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("StorageLocation", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.StorageLocation = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "StorageLocation", oldValue, value));
				OnPropertyChanged("StorageLocation", oldValue, value);
			}
		}
		private bool ShouldSerializeStorageLocation() { return false; }
        /// <summary>
        /// Gets or sets the DefaultMode of the Model.
        /// </summary>
		[DisplayName("Default Mode")]
		[Category("Other"),IntelliSense("The Default Mode of this Model.")]
		public TOM.ModeType DefaultMode {
			get {
			    return MetadataObject.DefaultMode;
			}
			set {
				var oldValue = DefaultMode;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DefaultMode", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DefaultMode = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DefaultMode", oldValue, value));
				OnPropertyChanged("DefaultMode", oldValue, value);
			}
		}
		private bool ShouldSerializeDefaultMode() { return false; }
        /// <summary>
        /// Gets or sets the DefaultDataView of the Model.
        /// </summary>
		[DisplayName("Default Data View")]
		[Category("Other"),IntelliSense("The Default Data View of this Model.")]
		public TOM.DataViewType DefaultDataView {
			get {
			    return MetadataObject.DefaultDataView;
			}
			set {
				var oldValue = DefaultDataView;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DefaultDataView", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DefaultDataView = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DefaultDataView", oldValue, value));
				OnPropertyChanged("DefaultDataView", oldValue, value);
			}
		}
		private bool ShouldSerializeDefaultDataView() { return false; }
        /// <summary>
        /// Gets or sets the Culture of the Model.
        /// </summary>
		[DisplayName("Culture")]
		[Category("Other"),IntelliSense("The Culture of this Model.")][TypeConverter(typeof(CultureConverter))]
		public string Culture {
			get {
			    return MetadataObject.Culture;
			}
			set {
				var oldValue = Culture;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Culture", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Culture = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Culture", oldValue, value));
				OnPropertyChanged("Culture", oldValue, value);
			}
		}
		private bool ShouldSerializeCulture() { return false; }
        /// <summary>
        /// Gets or sets the Collation of the Model.
        /// </summary>
		[DisplayName("Collation")]
		[Category("Other"),IntelliSense("The Collation of this Model.")]
		public string Collation {
			get {
			    return MetadataObject.Collation;
			}
			set {
				var oldValue = Collation;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Collation", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Collation = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Collation", oldValue, value));
				OnPropertyChanged("Collation", oldValue, value);
			}
		}
		private bool ShouldSerializeCollation() { return false; }

        /// <summary>
        /// Collection of localized descriptions for this Model.
        /// </summary>
        [Browsable(true),DisplayName("Descriptions"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDescriptions { private set; get; }
        /// <summary>
        /// Collection of localized names for this Model.
        /// </summary>
        [Browsable(true),DisplayName("Names"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedNames { private set; get; }


	
        internal override void RenewMetadataObject()
        {
            var tom = new TOM.Model();
            Handler.WrapperLookup.Remove(MetadataObject);
            MetadataObject.CopyTo(tom);
            MetadataObject = tom;
            Handler.WrapperLookup.Add(MetadataObject, this);
        }


		/// <summary>
		/// Creates a Model object representing an existing TOM Model.
		/// </summary>
		internal Model(TOM.Model metadataObject) : base(metadataObject)
		{
			TranslatedNames = new TranslationIndexer(this, TOM.TranslatedProperty.Caption);
			TranslatedDescriptions = new TranslationIndexer(this, TOM.TranslatedProperty.Description);
		}	

		public override bool Browsable(string propertyName) {
			switch (propertyName) {
				
				// Hides translation properties in the grid, unless the model actually contains translations:
				case "TranslatedNames":
				case "TranslatedDescriptions":
					return Model.Cultures.Any();
				
				default:
					return base.Browsable(propertyName);
			}
		}

    }

}
