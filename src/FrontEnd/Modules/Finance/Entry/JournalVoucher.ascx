﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JournalVoucher.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Finance.Entry.JournalVoucher"
    OverridePath="/Modules/Finance/JournalVoucher.mix" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<%@ Register TagPrefix="mixerp" Namespace="MixERP.Net.WebControls.Common" Assembly="MixERP.Net.WebControls.Common, Version=1.6.0.0, Culture=neutral, PublicKeyToken=a724a47a0879d02f" %>

<h2>
    <asp:Label ID="TitleLabel" runat="server" />
</h2>

<div class="ui tiny form segment">
    <div class="three fields">
        <div class="field">
            <label for="ValueDateTextBox">
                <asp:Literal ID="ValueDateLiteral" runat="server" />
            </label>
            <mixerp:DateTextBox ID="ValueDateTextBox" runat="server" CssClass="date" />
        </div>
        <div class="field">
            <label for="BookDateTextBox">
                <%=Titles.BookDate %>
            </label>
            <mixerp:DateTextBox 
                ID="BookDateTextBox" runat="server" Mode="Today" CssClass="date" />
        </div>
        <div class="field">
            <label for="ReferenceNumberInputText">
                <asp:Literal ID="ReferenceNumberLiteral" runat="server" />
            </label>
            <input type="text" id="ReferenceNumberInputText" runat="server" />
        </div>
    </div>
</div>

<input type="hidden" id="TransactionGridViewHidden" />

<div style="width: 100%; overflow: auto;">
    <table id="TransactionGridView" class="ui table segment" style="min-width: 1200px; max-width: 2000px;">
        <thead>
            <tr>
                <th style="width: 9%">
                    <label for="StatementReferenceInputText">
                        <asp:Literal runat="server" ID="StatementReferenceLiteral" />
                    </label>
                </th>
                <th scope="col" style="width: 7%;">
                    <label for="AccountNumberInputText">
                        <asp:Literal runat="server" ID="AccountNumberLiteral" />
                    </label>
                </th>
                <th style="width: 15%;">
                    <label for="AccountSelect">
                        <asp:Literal runat="server" ID="AccountLiteral" />
                    </label>
                </th>
                <th style="width: 8%;">
                    <label for="CashRepositorySelect">
                        <asp:Literal runat="server" ID="CashRepositoryLiteral" />
                    </label>
                </th>
                <th style="width: 8%;">
                    <label for="CurrencySelect">
                        <asp:Literal runat="server" ID="CurrencyLiteral" />
                    </label>
                </th>
                <th class="text-right" style="width: 10%;">
                    <label for="DebitInputText">
                        <asp:Literal runat="server" ID="DebitLiteral" />
                    </label>
                </th>
                <th class="text-right" style="width: 9%;">
                    <label for="CreditInputText">
                        <asp:Literal runat="server" ID="CreditLiteral" />
                    </label>
                </th>
                <th class="text-right" style="width: 7%;">
                    <label for="ERInputText">
                        <asp:Literal runat="server" ID="ERLiteral" />
                    </label>
                </th>
                <th class="text-right" style="width: 9%;">
                    <label for="LCDebitInputText">
                        <asp:Literal runat="server" ID="LCDebitLiteral" />
                    </label>
                </th>
                <th class="text-right" style="width: 9%;">
                    <label for="LCCreditInputText">
                        <asp:Literal runat="server" ID="LCCreditLiteral" />
                    </label>
                </th>
                <th style="width: 9%;">
                    <asp:Literal runat="server" ID="ActionLiteral" />
                </th>
            </tr>
        </thead>
        <tbody>
            <tr class="ui form footer-row">
                <td>
                    <input type="text" id="StatementReferenceInputText" title='Ctrl + Alt +S' />
                </td>
                <td>
                    <input type="text" id="AccountNumberInputText" title='Ctrl + Alt + T' />
                </td>
                <td>
                    <select id="AccountSelect" title='Ctrl + Alt + A'></select>
                </td>
                <td>
                    <select id="CashRepositorySelect"></select>
                </td>
                <td>
                    <select id="CurrencySelect"></select>
                </td>
                <td>
                    <input type="text" id="DebitInputText" class="text-right currency" title='Ctrl + Alt + D' />
                </td>
                <td>
                    <input type="text" id="CreditInputText" class="text-right currency" title='Ctrl + Alt + C' />
                </td>
                <td>
                    <input type="text" id="ERInputText" class="text-right decimal" />
                </td>
                <td>
                    <input type="text" id="LCDebitInputText" class="text-right currency" readonly="readonly" title='Ctrl + Alt + D' />
                </td>
                <td>
                    <input type="text" id="LCCreditInputText" class="text-right currency" readonly="readonly" title='Ctrl + Alt + C' />
                </td>
                <td>
                    <input type="button" id="AddInputButton" runat="server" class="ui small blue button" title='Ctrl + Return' />
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h4>
    <asp:Label ID="AttachmentLabel" runat="server" Text="Attachments" />
</h4>
<div id="AttachmentDiv" class="grey" style="display: none; padding-left: 24px;">
    <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
</div>

<div class="ui tiny form segment">
    <div class="field">
        <label for="CostCenterDropDownList">
            <asp:Literal ID="CostCenterLiteral" runat="server" />
        </label>
        <select id="CostCenterDropDownList">
        </select>
    </div>
    <div class="field">
        <label for="DebitTotalTextBox">
            <asp:Literal ID="DebitTotalLiteral" runat="server" />
        </label>
        <input type="text"
            id="DebitTotalTextBox"
            readonly="readonly"
            class="text-right currency" />
    </div>
    <div class="field">
        <label for="CreditTotalLiteral">
            <asp:Literal ID="CreditTotalLiteral" runat="server" />
        </label>
        <input type="text"
            id="CreditTotalTextBox"
            readonly="readonly"
            class="text-right currency" />
    </div>
    <button id="PostButton" type="button" class="ui small positive button">
        <asp:Literal runat="server" ID="PostTransactionLiteral" />
    </button>
</div>
<asp:Label runat="server" ID="ErrorLabelBottom" CssClass="big error"></asp:Label>

<script src="../Scripts/Entry/JournalVoucher.js"></script>
