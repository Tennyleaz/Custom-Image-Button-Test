# Custom-Image-Button-Test
A WPF custom usercontrol as image button.

## Usage
The `XImageButton` custom user control has several DependencyProperty you could change.

Most basic build-in members: 
* Name
* ToolTip
* Background
* BorderBrush
* BorderThickness
* Width and Height
* Click

Additional members:
* ImageWidth and ImageHeight
* TextContent
* ForeImages
* NormalImage
* HoverImage
* PressedImage
* DisabledImage
* HoverBrush

## Example
One could see an example button in [MainWindow.xaml](https://github.com/Tennyleaz/Custom-Image-Button-Test/blob/master/Custom%20Image%20Button%20Test/MainWindow.xaml)

Showcase image:

![animated png image](https://github.com/Tennyleaz/Custom-Image-Button-Test/blob/master/example%20apng.png)

(This is an animated png image. If you couldn't see it, change another browser!)

### Note
Avoid to set `Content` property in `XImageButton`. You may break the content inside the control. I haven't have time to fix this issue.
