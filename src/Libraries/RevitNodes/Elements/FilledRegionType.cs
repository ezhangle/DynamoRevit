﻿using System;
using Autodesk.Revit.DB;
using DynamoServices;
using Autodesk.DesignScript.Runtime;
using Revit.GeometryConversion;
using RevitServices.Persistence;
using RevitServices.Transactions;
using System.Collections.Generic;

namespace Revit.Elements
{
    /// <summary>
    /// Revit filled Region Type
    /// </summary>
    [DynamoServices.RegisterForTrace]
    public class FilledRegionType : Element
    {

        #region Internal Properties

        /// <summary>
        /// Internal reference to the Revit Element
        /// </summary>
        internal Autodesk.Revit.DB.FilledRegionType InternalRevitElement
        {
            get;
            private set;
        }

        /// <summary>
        /// Reference to the Element
        /// </summary>
        [SupressImportIntoVM]
        public override Autodesk.Revit.DB.Element InternalElement
        {
            get { return InternalRevitElement; }
        }

        #endregion

        #region Private mutators

        /// <summary>
        /// Set the internal Element, ElementId, and UniqueId
        /// </summary>
        private void InternalSetElement(Autodesk.Revit.DB.FilledRegionType element)
        {
            InternalRevitElement = element;
            InternalElementId = element.Id;
            InternalUniqueId = element.UniqueId;
        }

        #endregion

        #region Private constructors

        /// <summary>
        /// FilledRegionType
        /// </summary>
        /// <param name="FilledRegion"></param>
        private FilledRegionType(Autodesk.Revit.DB.FilledRegionType FilledRegion)
        {
            SafeInit(() => InitElement(FilledRegion));
        }


        #endregion

        #region Helpers for private constructors

        /// <summary>
        /// Init Element
        /// </summary>
        private void InitElement(Autodesk.Revit.DB.FilledRegionType element)
        {
            InternalSetElement(element);
        }

        #endregion

        #region Internal static constructors

        /// <summary>
        /// Create from existing
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="isRevitOwned"></param>
        /// <returns></returns>
        internal static FilledRegionType FromExisting(Autodesk.Revit.DB.FilledRegionType instance, bool isRevitOwned)
        {
            return new FilledRegionType(instance)
            { 
                IsRevitOwned = isRevitOwned
            };
        }

        #endregion


    }

}
