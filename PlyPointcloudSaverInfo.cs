using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace PlyPointcloudSaver
{
    public class PlyPointcloudSaverInfo : GH_AssemblyInfo
    {
        public override string Name => "PlyPointcloudSaver";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("12e12b02-874b-428d-a8f6-7a09e9b64931");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}