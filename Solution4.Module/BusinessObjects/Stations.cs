using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Solution4.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Stations : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Stations(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _kod;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Kod
        {
            get
            {
                return _kod;
            }
            set
            {
                SetPropertyValue<string>(nameof(Kod), ref _kod, value);
            }
        }
        private string _sehir;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Sehir
        {
            get
            {
                return _sehir;
            }
            set
            {
                SetPropertyValue<string>(nameof(Sehir), ref _sehir, value);
            }
        }

        double _birimFiyat;
        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }
            set
            {
                SetPropertyValue<double>(nameof(BirimFiyat), ref _birimFiyat, value);
            }
        }
        double _enlem;
        public double Enlem
        {
            get
            {
                return _enlem;
            }
            set
            {
                SetPropertyValue<double>(nameof(Enlem), ref _enlem, value);
            }
        }
        double _boylam;
        public double Boylam
        {
            get
            {
                return _boylam;
            }
            set
            {
                SetPropertyValue<double>(nameof(Boylam), ref _boylam, value);
            }
        }
    }
}