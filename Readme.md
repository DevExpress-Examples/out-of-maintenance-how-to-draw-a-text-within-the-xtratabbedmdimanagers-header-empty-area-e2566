<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616760/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2566)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MySkinTabPainter.cs](./CS/WindowsFormsApplication7/MySkinTabPainter.cs) (VB: [MySkinTabPainter.vb](./VB/WindowsFormsApplication7/MySkinTabPainter.vb))
* [MySkinViewInfoRegistrator.cs](./CS/WindowsFormsApplication7/MySkinViewInfoRegistrator.cs) (VB: [MySkinViewInfoRegistrator.vb](./VB/WindowsFormsApplication7/MySkinViewInfoRegistrator.vb))
* [MyXtraTabbedMdiManager.cs](./CS/WindowsFormsApplication7/MyXtraTabbedMdiManager.cs) (VB: [MyXtraTabbedMdiManager.vb](./VB/WindowsFormsApplication7/MyXtraTabbedMdiManager.vb))
<!-- default file list end -->
# How to draw a text within the XtraTabbedMdiManager's header empty area


<p>This sample demonstrates how to use empty space in the XtraTabbedMdiManager's header area between the rightmost tab header and control buttons on the right side to draw some custom text. To achieve this, it is required to override the <strong>DrawHeader</strong> method of the <strong>BaseTabPainter's</strong> descendant (the sample is based on a SkinTabPainter class). The functionality shown in the sample works only when the <strong>HeaderLocation</strong> property is set to the Top value. However, the demonstrated approach can be used to draw text when any other positions of the header are set.</p>

<br/>


