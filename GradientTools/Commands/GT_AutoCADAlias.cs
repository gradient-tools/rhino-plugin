using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using Rhino.ApplicationSettings;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace GradientTools.Commands
{
    public class GT_AutoCADAlias : Command
    {
        public GT_AutoCADAlias()
        {
            Instance = this;
        }

        public static GT_AutoCADAlias Instance { get; private set; }

        public override string EnglishName => "GT_AutoCADAlias";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {

            RhinoApp.WriteLine("The {0} will load AutoCAD aliases now.", EnglishName);

            // AutoCAD Alisases as a dict
            Dictionary<string, string> commandsAliases = new Dictionary<string, string>
            {
                {"3A", "_Array"},
                {"3DO", "_RotateView"},
                {"3F", "_Plane"},
                {"3P", "_Polyline"},
                {"A", "_Arc"},
                {"AA", "_Area"},
                {"AL", "_Align"},
                {"AP", "_-OptionsPage _Plugins"},
                {"AR", "_Array"},
                {"B", "_Block"},
                {"BH", "_Hatch _Boundary"},
                {"BO", "_CurveBoolean"},
                {"BR", "_Split"},
                {"C", "_Circle"},
                {"CH", "_Properties"},
                {"CHA", "_Chamfer"},
                {"CO", "_Copy"},
                {"COL", "_PropertiesPage _Pause _Object"},
                {"CP", "_Copy"},
                {"D", "_DocumentPropertiesPage _Dimensions"},
                {"DAL", "_DimAligned"},
                {"DAN", "_DimAngle"},
                {"DDI", "_DimDiameter"},
                {"DED", "_PropertiesPage _Pause _Dimension"},
                {"DI", "_Distance"},
                {"DIV", "_Divide"},
                {"DLI", "_Dim"},
                {"DRA", "_DimRadius"},
                {"DS", "_OptionsPage _ModelingAids"},
                {"DST", "_DocumentPropertiesPage _Dimensions"},
                {"DT", "_Text"},
                {"DXFIN", "_Import"},
                {"DXFOUT", "_Saveas"},
                {"E", "_Delete"},
                {"ED", "_EditText"},
                {"EL", "_Ellipse"},
                {"EX", "_Extend"},
                {"EXP", "_SaveAs"},
                {"EXT", "_ExtrudeCrv"},
                {"F", "_Fillet"},
                {"G", "_Group"},
                {"H", "_Hatch"},
                {"HE", "_DocumentPropertiesPage _Hatch"},
                {"HI", "_Make2D"},
                {"I", "_Insert"},
                {"IAD", "_BackgroundBitmap"},
                {"IAT", "_BackgroundBitmap _Place"},
                {"IMP", "_Import"},
                {"IN", "_BooleanIntersection"},
                {"J", "_Join"},
                {"L", "_Line"},
                {"LA", "_Layer"},
                {"LE", "_Leader"},
                {"LEN", "_Extend _Enter"},
                {"LI", "_What"},
                {"LO", "_Viewports"},
                {"LS", "_What"},
                {"LT", "_DocumentPropertiesPage _Linetypes"},
                {"LTS", "_DocumentPropertiesPage _Linetypes"},
                {"LTYPE", "_DocumentPropertiesPage _Linetypes"},
                {"M", "_Move"},
                {"MA", "_Properties"},
                {"ME", "_Measure"},
                {"MI", "_Mirror"},
                {"MO", "_Properties"},
                {"MS", "_Viewports"},
                {"MT", "_Text"},
                {"MV", "_Viewports"},
                {"O", "_Offset"},
                {"OP", "_Options"},
                {"ORBIT", "_RotateView"},
                {"OS", "_ShowOSnap _Toggle"},
                {"P", "_Pan"},
                {"PE", "_EditPtOn"},
                {"PL", "_Polyline"},
                {"PO", "_Point"},
                {"POL", "_Polygon"},
                {"PR", "_PropertiesPage _Object"},
                {"PRCLOSE", "_-Properties _Visible _No _Enter"},
                {"PROPS", "_PropertiesPage _Object"},
                {"PS", "_Viewports"},
                {"PU", "_Purge"},
                {"QC", "_Calc"},
                {"REC", "_Rectangle"},
                {"REG", "_PlanarSrf"},
                {"REV", "_Revolve"},
                {"RO", "_Rotate"},
                {"RPR", "_DocumentPropertiesPage _Render"},
                {"RR", "_Render"},
                {"SC", "_Scale"},
                {"SCR", "_ReadCommandFile"},
                {"SE", "_OptionsPage _ModelingAids"},
                {"SEC", "_Section"},
                {"SET", "_Options"},
                {"SHA", "_Shade"},
                {"SL", "_Section"},
                {"SN", "_DocumentPropertiesPage _Grid"},
                {"SO", "_3DFace"},
                {"SPE", "_PointsOn"},
                {"SPLINE", "_InterpCrv"},
                {"SPL", "_InterpCrv"},
                {"SU", "_BooleanDifference"},
                {"T", "_Text"},
                {"TI", "_Viewports"},
                {"TO", "_Toolbar"},
                {"TOR", "_Torus"},
                {"TR", "_Trim"},
                {"UC", "_NamedCPlane"},
                {"UN", "_DocumentPropertiesPage _Units"},
                {"UNI", "_BooleanUnion"},
                {"V", "_NamedView"},
                {"VP", "_PlaceCameraTarget"},
                {"VPORTS", "_ReadViewportsFromFile"},
                {"W", "_ExportWithOrigin"},
                {"WB", "_ExportWithOrigin"},
                {"X", "_Explode"},
                {"XA", "_-Worksesson _Attach _Browse"},
                {"XR", "_Worksession"},
                {"Z", "'_Zoom"},
                {"ZE", "'_Zoom _Extents"},
            };

            foreach (KeyValuePair<string, string> pair in commandsAliases)
            {
                Rhino.ApplicationSettings.CommandAliasList.Add(pair.Key, pair.Value);
            }
            
            RhinoApp.WriteLine("AutoCAD aliases added.");

            return Result.Success;
        }
    }
}
