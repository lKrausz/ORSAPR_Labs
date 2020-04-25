using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwConnector;
using SolidWorks.Interop.sldworks;

namespace Model
{
    public class GlassBuilder
    {
        public void BuildGlass(IModelDoc2 swModel, GlassParams glass)
        {
            CreatePoint(swModel, glass.GetHeight());
            CreateSketchPlane(swModel, "Point1@Эскиз1", glass.GetHeight());
            CreateCircle(swModel, "Plane2@Трехмерный эскиз1", "EXTSKETCHSURFACES", glass.GetTopRadius());
            CreateCircle(swModel, "Сверху", "PLANE", glass.GetBottomRadius());

            swModel.Extension.SelectByID2("Эскиз2", "SKETCH", 0, 0, 0, false, 1, null, 0);
            swModel.Extension.SelectByID2("Эскиз3", "SKETCH", 0, 0, 0, true, 1, null, 0);
            swModel.FeatureManager.InsertProtrusionBlend(false, true, false, 1, 0, 0, 1, 1, true, true, false, 0, 0, 0, true, true, true);
            swModel.ClearSelection2(true);

            CreateCircle(swModel, "Plane2@Трехмерный эскиз1", "EXTSKETCHSURFACES", glass.GetTopRadius() - glass.GetWallThickness());
            CreatePoint(swModel, glass.GetBottomThickness());
            CreateSketchPlane(swModel, "Point1@Эскиз5", glass.GetBottomThickness());
            CreateCircle(swModel, "Plane2@Трехмерный эскиз2", "EXTSKETCHSURFACES", glass.GetBottomRadius() - glass.GetWallThickness());

            swModel.Extension.SelectByID2("Эскиз4", "SKETCH", 0, 0, 0, false, 1, null, 0);
            swModel.Extension.SelectByID2("Эскиз6", "SKETCH", 0, 0, 0, true, 1, null, 0);
            swModel.FeatureManager.InsertCutBlend(false, true, false, 1, 0, 0, false, 0, 0, 0, true, true);
            swModel.ClearSelection2(true);

            swModel.Extension.SelectByID2("Эскиз2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            Object myFeature = swModel.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, 0.02, 0.02, false, false, false, false, 0, 0, false, false, false, false, true, true, true, 0, 0, false);

            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Эскиз4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            myFeature = swModel.FeatureManager.FeatureCut4(true, false, false, 0, 0, 0.02, 0.02, false, false, false, false, 0, 0, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
            swModel.SelectionManager.EnableContourSelection = false;
        }

        public void CreateCircle(IModelDoc2 swModel, string Name, string Type, double R)
        {
            swModel.SketchManager.InsertSketch(true);
            swModel.Extension.SelectByID2(Name, Type, 0, 0, 0, false, 0, null, 0);
            Object skSegment4 = swModel.SketchManager.CreateCircle(0, 0, 0, R, R, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
        }
        public void CreatePoint(IModelDoc2 swModel, double height)
        {
            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            Object skPoint2 = swModel.SketchManager.CreatePoint(0, height, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
        }

        public void CreateSketchPlane(IModelDoc2 swModel, string Name, double height)
        {
            swModel.SketchManager.Insert3DSketch(true);
            swModel.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2(Name, "EXTSKETCHPOINT", 0, height, 0, true, 0, null, 0);
            swModel.SketchManager.CreateSketchPlane(7, 9, 0);
            swModel.Extension.SelectByID2("Plane2", "SKETCHSURFACES", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.Insert3DSketch(true);
            swModel.ClearSelection2(true);
        }
    }
}
