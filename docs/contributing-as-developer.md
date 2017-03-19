#Contributing as Developer

We would love to have you with us in this project. However, you would need to sign the 
[Contributor License Agreement](contributor-license-agreement.md) before submitting contributions.

Moreover, you will also need to create an account in [MixERP Forum](http://mixerp.org/forum), and ask your questions there.


##Dependency
Adding a new dependency needs to discussed with and approved by the repository owner (binodnp) beforehand.


#Coding Style

* Use 4 spaces instead of a tab.
* Namespaces, type names, member names, and parameter names must use complete words or standard abbreviations.


**Pascal Case**

* Function and Methods.
* Resource Strings (Except ScrudResource).
* Enumerators. Name and Collection.
* Class, Namespace.
* Properties.
* ASP.net Server Control and HTML Control ids.
* Javascript class objects and event names.

**Camel Case**

* Variables, Objects, and Parameters.

**Lower Case Underscore**
* Database objects
* Scrud Resources (*.resx)

**Naming ASP.net Server Controls and Html Controls**

Names should be spelled in American English. The control id attribute should suffix the control name and type to suggest the type of control.

**Correct**

```markup
<asp:TextBox ID="FirstNameTextBox" runat="server" />

<input type="text" id="FirstNameInputText" runat="server" />

<asp:Button ID="SaveButton" runat="server" />

<input type="button" id="SaveInputButton" />

<button type="button" id="SaveButton" />

```

**Incorrect**

```markup
<asp:TextBox ID="txt_FirstName" runat="server" />

<input type="text" id="FirstNameTB" runat="server" />

<asp:Button ID="SaveBtn" runat="server" />

<input type="button" id="Save_Button" />

<button type="button" id="BtnSave" />

```

##Other Important Rules to Follow
* Functions and methods names must always begin with verbs.
* Class names should be singular nouns.
* Collection, array, list, IEnumerable and similar objects should be plural.
* Controls implementing IDisposable should always remove event handlers. Please do not set 
  event delegate to null on Dispose() method.


##Related Topics
* [Contribution Guidelines](contribution-guidelines.md)