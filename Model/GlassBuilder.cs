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
        private IModelDoc2 _swModel;
        public void BuildGlass(SldWorks swApp, IModelDoc2 swModel, GlassParams glass)
        {
            double R;

            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            SketchPoint skPoint = swModel.SketchManager.CreatePoint(0, glass.GetHeight(), 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            swModel.SketchManager.Insert3DSketch(true);
            swModel.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Point1@Эскиз1", "EXTSKETCHPOINT", 0, glass.GetHeight(), 0, true, 0, null, 0);
            swModel.SketchManager.CreateSketchPlane(7, 9, 0);
            swModel.Extension.SelectByID2("Plane2", "SKETCHSURFACES", 0, 0, 0, false, 0, null, 0);

            swModel.SketchManager.Insert3DSketch(true);
            swModel.ClearSelection2(true);


            swModel.SketchManager.InsertSketch(true);
            swModel.Extension.SelectByID2("Plane2@Трехмерный эскиз1", "EXTSKETCHSURFACES", -5.95682725413553E-02, 0.12, -4.83601407177048E-03, false, 0, null, 0);
            R = glass.GetTopRadius();
            Object skSegment = swModel.SketchManager.CreateCircle(0, 0, 0, R, R, 0);

            swModel.ClearSelection2(true);

            swModel.SketchManager.InsertSketch(true);
            swModel.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, false, 0, null, 0);
            R = glass.GetBottomRadius();
            Object skSegment1 = swModel.SketchManager.CreateCircle(0, 0, 0, R, R, 0);
            swModel.SketchManager.InsertSketch(true);

            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Эскиз2", "SKETCH", 0, 0, 0, false, 1, null, 0);
            swModel.Extension.SelectByID2("Эскиз3", "SKETCH", 0, 0, 0, true, 1, null, 0);
            swModel.FeatureManager.InsertProtrusionBlend(false, true, false, 1, 0, 0, 1, 1, true, true, false, 0, 0, 0, true, true, true);

            swModel.ClearSelection2(true);


            swModel.SketchManager.InsertSketch(true);
            swModel.Extension.SelectByID2("Plane2@Трехмерный эскиз1", "EXTSKETCHSURFACES", -5.95682725413553E-02, 0.12, -4.83601407177048E-03, false, 0, null, 0);
            R = glass.GetTopRadius() - glass.GetWallThickness();
            Object skSegment3 = swModel.SketchManager.CreateCircle(0, 0, 0, R, R, 0);
            swModel.SketchManager.InsertSketch(true); 
            swModel.ClearSelection2(true);


            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            Object skPoint2 = swModel.SketchManager.CreatePoint(0, glass.GetBottomThickness(), 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            swModel.SketchManager.Insert3DSketch(true);
            swModel.Extension.SelectByID2("Сверху", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.Extension.SelectByID2("Point1@Эскиз5", "EXTSKETCHPOINT", 0, glass.GetBottomThickness(), 0, true, 0, null, 0);
            swModel.SketchManager.CreateSketchPlane(7, 9, 0);
            swModel.Extension.SelectByID2("Plane2", "SKETCHSURFACES", 0, 0, 0, false, 0, null, 0);

            swModel.SketchManager.Insert3DSketch(true);
            swModel.ClearSelection2(true);



            swModel.SketchManager.InsertSketch(true);
            swModel.Extension.SelectByID2("Plane2@Трехмерный эскиз2", "EXTSKETCHSURFACES", 5.78105039385264E-02, 0.015, -5.17971998337998E-02, false, 0, null, 0);
            R = glass.GetBottomRadius() - glass.GetWallThickness();
            Object skSegment4 = swModel.SketchManager.CreateCircle(0, 0, 0, R, R, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);

            swModel.Extension.SelectByID2("Эскиз4", "SKETCH", -4.23572146498909E-02, -1.51942873180374E-02, 0, false, 1, null, 0);
            swModel.Extension.SelectByID2("Эскиз6", "SKETCH", -2.73969261301075E-02, -1.22232744639656E-02, 0, true, 1, null, 0);
            swModel.FeatureManager.InsertCutBlend(false, true, false, 1, 0, 0, false, 0, 0, 0, true, true);
            swModel.ClearSelection2(true);

            swModel.Extension.SelectByID2("Эскиз2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            Object myFeature = swModel.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, 0.02, 0.02, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Эскиз4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            myFeature = swModel.FeatureManager.FeatureCut4(true, false, false, 0, 0, 0.02, 0.02, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
            swModel.SelectionManager.EnableContourSelection = false;
        }
    }
}
