Module mGlobalVariables
    Public UserWizard As Boolean
    Public UserControl As Boolean
    Public RegistrationMenu As Boolean = False
    Public Attachments(1000) As String
    Public strHostName As String
    Public strIPAddress As String
    Public ServerStarted As Boolean = False
    Public CompanyIndex As Boolean = False
    Public MainTask As String
    Public FromSetupGuide As String
    Public periodvalue As String
    Public Shortcut(100) As String
    Public cAccountID(107) As String
    Public cAccountDecription(107) As String
    Public cSimpleAccountID(56) As String
    Public cSimpleAccountDecription(56) As String
    Public cAccountType(15) As String
    Public cSimpleAccountType(15) As String
    Public cCompID As String
    Public cCompName As String
    Public cPeriod As String
    Public cAddress1 As String
    Public cAddress2 As String
    Public cCity As String
    Public cState As String
    Public cZipCode As String
    Public cCountry As String
    Public cPhone As String
    Public cCompanyType As String
    Public cFedEmpID As String
    Public cSTEmprID As String
    Public cSTUnEmpID As String
    Public cFax As String
    Public cWebsite As String
    Public cEmail As String
    Public cBusinessType As String
    Public cAccountingMethod As String
    Public cPostingMethod As String
    Public cAccountingPeriod As String
    Public cPeriods As Integer
    Public cStartingDate As String
    Public cStartingMonth As String

    Public UpdateUser As Boolean = False
    Public UserID As String
    Public UserRole As String
    Public UserLogin As Boolean = False
    Public CurrentUser As String

    Public UpdateAccounts As Boolean
    Public AccountID As String

    Public UpdateCustomer As Boolean
    Public CustomerID As String
    Public CustomerName As String

    Public SalesTaxWizard As String
    Public IndividualTax As Integer = 0
    Public TaxAccount As String = ""
    Public TaxAgencyID(5) As String
    Public TaxAgencyName(5) As String
    Public TaxVendor(5) As String
    Public TaxAgencyAccount(5) As String
    Public TaxRate(5) As Decimal
    Public TaxID As String
    Public TaxName As String
    Public TaxFreight As String

    Public UpdatePriceLevel As Boolean
    Public LevelName As String

    Public UpdatePayment As Boolean
    Public PaymentID As String

    Public UpdateQuote As Boolean = False
    Public QuoteNo As String
    Public QuotesNote As String

    Public UpdateSalesOrder As Boolean = False
    Public SalesOrderNo As String
    Public SalesOrderNote As String

    Public UpdateSalesInvoice As Boolean = False
    Public SalesInvoiceNo As String
    Public SalesInvoiceNote As String

    Public UpdateFlyingInvoice As Boolean = False
    Public FlyingInvoiceNo As String
    Public FlyingInvoiceNote As String

    Public UpdateCustomerCredit As Boolean = False
    Public CustomerCreditNo As String
    Public CustomerCreditNote As String

    Public UpdateVendor As Boolean = False
    Public VendorID As String
    Public VendorName As String

    Public UpdateService As Boolean = False
    Public ServiceReturnNo As String
    Public ServiceNote As String

    Public UpdatePurchaseOrder As Boolean = False
    Public UpdateAutoPurchaseOrder As Boolean = False
    Public PurchaseNo As String
    Public AutoPurchaseNo As String
    Public PurchaseOrderNote As String
    Public AutoPurchaseNote As String

    Public UpdateVendorCredit As Boolean = False
    Public VendorCreditNo As String
    Public VendorCreditNote As String

    Public UpdateInventory As Boolean = False
    Public ItemID As String
    Public InventoryItemNote As String
    Public ItemName As String
    Public ItemType As String
    Public OnHandQnty As Decimal
    Public LeveltPrice As Decimal
    Public LastSold As Decimal

    Public UpdateBankDeposit As Boolean = False
    Public BankDepositID As String
    Public BankDepositNote As String

    Public UpdateCheck As Boolean = False
    Public CheckNo As String

    Public UpdateMemPayment As Boolean = False
    Public MemPaymentID As String

    Public UpdateReceipt As Boolean
    Public ReceiveID As String

    Public CreditNoteNo As String

    Public ReportCustomer As Boolean
    Public ReportVendor As Boolean
    Public ReportInventory As Boolean
    Public ReportBanking As Boolean
    Public ReportCompany As Boolean
End Module
