using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;

class TestWindow : Formium
{
    // 设置窗体样式类型，HostWindowType.System是Windows原生窗体
    public override HostWindowType WindowType => HostWindowType.System;

    // 指定启动Url
    public override string StartUrl => "https://www.bing.com";

    public TestWindow()
    {
        // 在此处设置窗口样式
        Size = new System.Drawing.Size(1024, 768);
    }

    protected override void OnReady()
    {
        // 在此处进行浏览器相关操作
        
    }
}