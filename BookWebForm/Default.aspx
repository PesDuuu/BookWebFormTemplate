<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookWebForm._Default" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="CSRFToken" runat="server" Value="<%= AntiForgery.GetTokens().FormToken %>" />
    <main class="container">
        <section class="row" aria-labelledby="aspnetTitle">
            <div class="col-md-12 text-center">
                <h1 id="aspnetTitle">ASP.NET</h1>
                <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
                <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
            </div>
        </section>

        <div class="row mt-4">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
                    A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
                </p>
                <p>
                    <a class="btn btn-secondary" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Get more libraries</h2>
                <p>
                    NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
                </p>
                <p>
                    <a class="btn btn-secondary" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-secondary" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>

        <div class="row mt-4">
            <section class="col-md-4" aria-labelledby="testBtn">
                <h2 id="testBtn">Button Testing</h2>
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Hello, World!" CssClass="form-label"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Text="Click Me" CssClass="btn btn-info" OnClick="Button1_Click" />
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="btnLoad">
                <h2 id="btnLoad">Load Book</h2>
                <p>
                    <asp:Button ID="btnLoadBook" runat="server" Text="Load Book" CssClass="btn btn-info" OnClick="btnLoadBook_Click" />
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="btnSearchID">
                <h2 id="btnSearchID">Search Book by ID</h2>
                <p>
                    <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Enter Book ID" />
                    <asp:Button ID="btnSearchBook" runat="server" Text="Search" CssClass="btn btn-info mt-2" OnClick="btnSearchBook_Click" />
                </p>
            </section>
        </div>

        <div class="row mt-4">
            <section class="col-md-12">
                <h2>Book Records</h2>
                <asp:GridView ID="GridViewBooks" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" />
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="PageCount" HeaderText="Page Count" />
                        <asp:BoundField DataField="Isbn" HeaderText="Isbn" />
                        <asp:TemplateField HeaderText="Authors">
                            <ItemTemplate>
                                <asp:Literal ID="LiteralAuthors" runat="server" Text='<%# string.Join(", ", Eval("Authors") as List<string>) %>'></asp:Literal>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </section>
        </div>
    </main>

</asp:Content>
