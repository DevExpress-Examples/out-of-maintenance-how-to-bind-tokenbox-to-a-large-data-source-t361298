<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549172/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T361298)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* [Product.cs](./CS/DXWebApplication1/Models/Product.cs) (VB: [Product.vb](./VB/DXWebApplication1/Models/Product.vb))
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to bind TokenBox to a large data source
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t361298/)**
<!-- run online end -->


<p>This example demonstrates how to bind the TokenBox extension to a large data source on the client side.<br>Create the <em>GetFilteredData</em> method that should return a list of items based on a string filter parameter. Then, handle the client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientTextEdit_KeyUptopic">MVCxClientTokentBox KeyUp</a> event and execute the <em>GetFilteredData</em> method using jQuery ajax.</p>
<p>Create the <em>setData</em> method on the client side. After that, remove items that were added earlier and add new items to the TokenBox item collection in the <em>setData</em> method. Note that for certain purposes, it is possible to disable adding custom tokens using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebTokenBoxProperties_AllowCustomTokenstopic">AllowCustomTokens</a> property and set the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxAutoCompleteBoxBase_IncrementalFilteringDelaytopic">IncrementalFilteringDelay</a> property to 800.</p>
<p>To reduce the server overload by avoiding unnecessary requests, it is recommended to add the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientComboBox_BeginUpdatetopic">ASPxClientComboBox.BeginUpdate</a> and <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientComboBox_EndUpdatetopic">ASPxClientComboBox.EndUpdate</a> methods. Then, set them at the beginning and end of the <em>setData</em> method.</p>
<p>Finally, add a condition to check if the input value length is more than the minFilterLength variable and add timeout to allow a user to input the entire text and then show obtained items. Handle the client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientTokenBox_TokensChangedtopic">ASPxClientTokenBox.TokensChanged</a> event and remove all items from the drop-down window.<br>Note: item highlighting will not work.<br><br>See also:<br><a href="https://www.devexpress.com/Support/Center/p/T457341">How to bind ASPxTokenBox to a large data source</a></p>

<br/>


