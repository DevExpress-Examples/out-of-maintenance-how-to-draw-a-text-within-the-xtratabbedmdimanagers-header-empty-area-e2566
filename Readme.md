<!-- default file list -->
*Files to look at*:

* [MySkinTabPainter.cs](./CS/WindowsFormsApplication7/MySkinTabPainter.cs) (VB: [MySkinTabPainter.vb](./VB/WindowsFormsApplication7/MySkinTabPainter.vb))
* [MySkinViewInfoRegistrator.cs](./CS/WindowsFormsApplication7/MySkinViewInfoRegistrator.cs) (VB: [MySkinViewInfoRegistrator.vb](./VB/WindowsFormsApplication7/MySkinViewInfoRegistrator.vb))
* [MyXtraTabbedMdiManager.cs](./CS/WindowsFormsApplication7/MyXtraTabbedMdiManager.cs) (VB: [MyXtraTabbedMdiManager.vb](./VB/WindowsFormsApplication7/MyXtraTabbedMdiManager.vb))
<!-- default file list end -->
# How to draw a text within the XtraTabbedMdiManager's header empty area


<p>This sample demonstrates how to use empty space in the XtraTabbedMdiManager's header area between the rightmost tab header and control buttons on the right side to draw some custom text. To achieve this, it is required to override the <strong>DrawHeader</strong> method of the <strong>BaseTabPainter's</strong> descendant (the sample is based on a SkinTabPainter class). The functionality shown in the sample works only when the <strong>HeaderLocation</strong> property is set to the Top value. However, the demonstrated approach can be used to draw text when any other positions of the header are set.</p>

<br/>


