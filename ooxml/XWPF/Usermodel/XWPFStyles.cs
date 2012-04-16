/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace NPOI.XWPF.UserModel
{
    using System;
    using System.Collections.Generic;
    using NPOI.OpenXml4Net.OPC;
    using NPOI.OpenXmlFormats.Wordprocessing;
    using System.IO;
    using System.Xml;

    /**
     * @author Philipp Epp
     *
     */
    public class XWPFStyles : POIXMLDocumentPart
    {

        private List<XWPFStyle> listStyle = new List<XWPFStyle>();
        private CT_Styles ctStyles;
        XWPFLatentStyles latentStyles;

        /**
         * Construct XWPFStyles from a package part
         *
         * @param part the package part holding the data of the styles,
         * @param rel  the package relationship of type "http://schemas.Openxmlformats.org/officeDocument/2006/relationships/styles"
         */

        public XWPFStyles(PackagePart part, PackageRelationship rel)
            : base(part, rel)
        {
        }

        /**
         * Construct XWPFStyles from scratch for a new document.
         */
        public XWPFStyles()
        {
        }

        /**
         * Read document
         */

        protected void onDocumentRead()
        {
            /*StylesDocument stylesDoc;
            try
            {
                Stream is1 = GetPackagePart().GetInputStream();
                stylesDoc = StylesDocument.Factory.Parse(is1);
                ctStyles = stylesDoc.Styles;
                latentStyles = new XWPFLatentStyles(ctStyles.LatentStyles, this);

            }
            catch (XmlException e)
            {
                throw new POIXMLException();
            }
            //get any Style
            foreach (CTStyle style in ctStyles.StyleList)
            {
                listStyle.Add(new XWPFStyle(style, this));
            }*/
            throw new NotImplementedException();
        }


        protected void Commit()
        {
            /*XmlOptions xmlOptions = new XmlOptions(DEFAULT_XML_OPTIONS);
            xmlOptions.SaveSyntheticDocumentElement=(new QName(CTStyles.type.Name.NamespaceURI, "styles"));
            Dictionary<String,String> map = new Dictionary<String,String>();
            map.Put("http://schemas.Openxmlformats.org/officeDocument/2006/relationships", "r");
            map.Put("http://schemas.Openxmlformats.org/wordProcessingml/2006/main", "w");
            xmlOptions.SaveSuggestedPrefixes=(map);
            PackagePart part = GetPackagePart();
            OutputStream out1 = part.OutputStream;
            ctStyles.Save(out, xmlOptions);
            out1.Close();*/
            throw new NotImplementedException();
        }


        /**
         * Sets the ctStyles
         * @param styles
         */
        public void SetStyles(CT_Styles styles)
        {
            ctStyles = styles;
        }

        /**
         * Checks whether style with styleID exist
         * @param styleID		styleID of the Style in the style-Document
         * @return				true if style exist, false if style not exist
         */
        public bool styleExist(String styleID)
        {
            /*
            foreach (XWPFStyle style in listStyle)
            {
                if (style.StyleId.Equals(styleID))
                    return true;
            }
            return false;*/
            throw new NotImplementedException();
        }
        /**
         * add a style to the document
         * @param style				
         * @throws IOException		 
         */
        public void AddStyle(XWPFStyle style)
        {
            /*listStyle.Add(style);
            ctStyles.AddNewStyle();
            int pos = (ctStyles.StyleList.Size()) - 1;
            ctStyles.StyleArray=(pos, style.CTStyle);
                */
            throw new NotImplementedException();
        }
        /**
         *get style by a styleID 
         * @param styleID	styleID of the searched style
         * @return style
         */
        public XWPFStyle GetStyle(String styleID)
        {
            /*foreach (XWPFStyle style in listStyle)
            {
                if (style.StyleId.Equals(styleID))
                    return style;
            }
            return null;*/
            throw new NotImplementedException();
        }

        /**
         * Get the styles which are related to the parameter style and their relatives
         * this method can be used to copy all styles from one document to another document 
         * @param style
         * @return a list of all styles which were used by this method 
         */
        public List<XWPFStyle> GetUsedStyleList(XWPFStyle style)
        {
            List<XWPFStyle> usedStyleList = new List<XWPFStyle>();
            usedStyleList.Add(style);
            return GetUsedStyleList(style, usedStyleList);
        }

        /** 
         * Get the styles which are related to parameter style
         * @param style
         * @return all Styles of the parameterList
         */
        private List<XWPFStyle> GetUsedStyleList(XWPFStyle style, List<XWPFStyle> usedStyleList)
        {
            /*String basisStyleID = style.BasisStyleID;
            XWPFStyle basisStyle = GetStyle(basisStyleID);
            if ((basisStyle != null) && (!usedStyleList.Contains(basisStyle)))
            {
                usedStyleList.Add(basisStyle);
                GetUsedStyleList(basisStyle, usedStyleList);
            }
            String linkStyleID = style.LinkStyleID;
            XWPFStyle linkStyle = GetStyle(linkStyleID);
            if ((linkStyle != null) && (!usedStyleList.Contains(linkStyle)))
            {
                usedStyleList.Add(linkStyle);
                GetUsedStyleList(linkStyle, usedStyleList);
            }

            String nextStyleID = style.NextStyleID;
            XWPFStyle nextStyle = GetStyle(nextStyleID);
            if ((nextStyle != null) && (!usedStyleList.Contains(nextStyle)))
            {
                usedStyleList.Add(linkStyle);
                GetUsedStyleList(linkStyle, usedStyleList);
            }
            return usedStyleList;*/
            throw new NotImplementedException();
        }

        /**
         * Sets the default spelling language on ctStyles DocDefaults parameter
         * @param strSpellingLanguage
         */
        public void SetSpellingLanguage(String strSpellingLanguage)
        {
            /*CTDocDefaults docDefaults = null;
            CTRPr RunProps = null;
            CTLanguage lang = null;

            // Just making sure we use the members that have already been defined
            if (ctStyles.IsSetDocDefaults())
            {
                docDefaults = ctStyles.DocDefaults;
                if (docDefaults.IsSetRPrDefault())
                {
                    CTRPrDefault RPrDefault = docDefaults.RPrDefault;
                    if (RPrDefault.IsSetRPr())
                    {
                        RunProps = RPrDefault.RPr;
                        if (RunProps.IsSetLang())
                            lang = RunProps.Lang;
                    }
                }
            }

            if (docDefaults == null)
                docDefaults = ctStyles.AddNewDocDefaults();
            if (RunProps == null)
                RunProps = docDefaults.AddNewRPrDefault().AddNewRPr();
            if (lang == null)
                lang = RunProps.AddNewLang();

            lang.Val = (strSpellingLanguage);
            lang.Bidi = (strSpellingLanguage);*/
            throw new NotImplementedException();
        }

        /**
         * Sets the default East Asia spelling language on ctStyles DocDefaults parameter
         * @param strEastAsia
         */
        public void SetEastAsia(String strEastAsia)
        {
            /*CTDocDefaults docDefaults = null;
            CTRPr RunProps = null;
            CTLanguage lang = null;

            // Just making sure we use the members that have already been defined
            if (ctStyles.IsSetDocDefaults())
            {
                docDefaults = ctStyles.DocDefaults;
                if (docDefaults.IsSetRPrDefault())
                {
                    CTRPrDefault RPrDefault = docDefaults.RPrDefault;
                    if (RPrDefault.IsSetRPr())
                    {
                        RunProps = RPrDefault.RPr;
                        if (RunProps.IsSetLang())
                            lang = RunProps.Lang;
                    }
                }
            }

            if (docDefaults == null)
                docDefaults = ctStyles.AddNewDocDefaults();
            if (RunProps == null)
                RunProps = docDefaults.AddNewRPrDefault().AddNewRPr();
            if (lang == null)
                lang = RunProps.AddNewLang();

            lang.EastAsia = (strEastAsia);
             * */
            throw new NotImplementedException();
        }

        /**
         * Sets the default font on ctStyles DocDefaults parameter
         * @param fonts
         */
        public void SetDefaultFonts(CT_Fonts fonts)
        {
            /*CT_DocDefaults docDefaults = null;
            CT_RPr RunProps = null;

            // Just making sure we use the members that have already been defined
            if (ctStyles.IsSetDocDefaults())
            {
                docDefaults = ctStyles.DocDefaults;
                if (docDefaults.IsSetRPrDefault())
                {
                    CTRPrDefault RPrDefault = docDefaults.RPrDefault;
                    if (RPrDefault.IsSetRPr())
                    {
                        RunProps = RPrDefault.RPr;
                    }
                }
            }

            if (docDefaults == null)
                docDefaults = ctStyles.AddNewDocDefaults();
            if (RunProps == null)
                RunProps = docDefaults.AddNewRPrDefault().AddNewRPr();

            RunProps.RFonts = (fonts);*/
            throw new NotImplementedException();
        }


        /**
         * Get latentstyles
         */
        public XWPFLatentStyles GetLatentStyles()
        {
            return latentStyles;
        }

        /**
         * Get the style with the same name
         * if this style is not existing, return null
         */
        public XWPFStyle GetStyleWithSameName(XWPFStyle style)
        {
            foreach (XWPFStyle ownStyle in listStyle)
            {
                if (ownStyle.HasSameName(style))
                {
                    return ownStyle;
                }
            }
            return null;

        }
    }//end class

}