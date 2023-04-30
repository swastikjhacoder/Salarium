Module mDefaultValues
#Region "Customer Default Values..."
    Public CSTStandardTerms As String = ""
    Public CSTNetDueIn As Integer = 0
    Public CSTDiscountIn As Integer = 0
    Public CSTDiscountPercent As Decimal = 0.0
    Public CSTCreditLimit As Decimal = 0.0
    Public CSTCreditStatus As String = ""
    Public CSTGLSalesAccount As String = ""
    Public CSTGLDiscountAccount As String = ""
    Public CSTGLFinanceChargeAccount As String = ""
    Public CSTAgeInvoiceBy As String = ""
    Public CSTAgingCategoryDays1 As Integer = 0
    Public CSTAgingCategoryHeading1 As String = ""
    Public CSTAgingCategoryDays2 As Integer = 0
    Public CSTAgingCategoryHeading2 As String = ""
    Public CSTAgingCategoryDays3 As Integer = 0
    Public CSTAgingCategoryHeading3 As String = ""
    Public CSTAgingCategoryHeading4 As String = ""
    Public CSTCustomField1 As String = ""
    Public CSTCustomField2 As String = ""
    Public CSTCustomField3 As String = ""
    Public CSTCustomField4 As String = ""
    Public CSTCustomField5 As String = ""
    Public CSTCustomFieldEnable1 As String = ""
    Public CSTCustomFieldEnable2 As String = ""
    Public CSTCustomFieldEnable3 As String = ""
    Public CSTCustomFieldEnable4 As String = ""
    Public CSTCustomFieldEnable5 As String = ""
    Public CSTDaysOverDue As Integer = 0
    Public CSTDueAmountUpto As Decimal = 0.0
    Public CSTAnnualInterestRate As Decimal = 0.0
    Public CSTBalanceAbove As Decimal = 0.0
    Public CSTFinanceCharge As Decimal = 0.0
    Public CSTChargeInterest As String = ""
    Public CSTAppearsOnInvoice As String = ""
    Public CSTPrintFinanceChargeWarning As String = ""
    Public CSTFinanceChargeWarning As String = ""
    Public CSTPaymentMethod1 As String = ""
    Public CSTPaymentMethod2 As String = ""
    Public CSTPaymentMethod3 As String = ""
    Public CSTPaymentMethod4 As String = ""
    Public CSTPaymentMethod5 As String = ""
    Public CSTPaymentMethod6 As String = ""
    Public CSTPaymentMethod7 As String = ""
    Public CSTPaymentMethod8 As String = ""
    Public CSTPaymentMethod9 As String = ""
    Public CSTPaymentMethod10 As String = ""
#End Region
#Region "CustomerStatementDefault..."
    Public STActivityEnable As String
    Public STBalance As Decimal
    Public STBalanceEnable As String
    Public STInvoiceDueDays As Integer
    Public STInvoiceDueDaysEnable As String
    Public STNegativeBalance As String
    Public STZeroBalance As String
    Public STStatementType As String
    Public STCompanyPrint As String
    Public STInvoiceDueDays1 As Integer
    Public STInvoiceDueDays2 As Integer
    Public STInvoiceDueDays3 As Integer
    Public STMessage1 As String
    Public STMessage2 As String
    Public STMessage3 As String
    Public STInvoiceMessage As String
#End Region
#Region "Vendor Default Values..."
    Public VNDStandardTerm As String = ""
    Public VNDNetDueIn As Integer = 0
    Public VNDDiscountIn As Integer = 0
    Public VNDDiscountPercent As Decimal = 0.0
    Public VNDCreditLimit As Decimal = 0.0
    Public VNDExpenseAccount As String = ""
    Public VNDGLDiscountAccount As String = ""
    Public VNDAgeInvoiceBy As String = ""
    Public VNDAgingDays1 As Integer = 0
    Public VNDAgingHeading1 As String = ""
    Public VNDAgingDays2 As Integer = 0
    Public VNDAgingHeading2 As String = ""
    Public VNDAgingDays3 As Integer = 0
    Public VNDAgingHeading3 As String = ""
    Public VNDAgingHeading4 As String = ""
    Public VNDCustomFeild1 As String = ""
    Public VNDCustomFeild2 As String = ""
    Public VNDCustomFeild3 As String = ""
    Public VNDCustomFeild4 As String = ""
    Public VNDCustomFeild5 As String = ""
    Public VNDCustomFeildEnable1 As String = ""
    Public VNDCustomFeildEnable2 As String = ""
    Public VNDCustomFeildEnable3 As String = ""
    Public VNDCustomFeildEnable4 As String = ""
    Public VNDCustomFeildEnable5 As String = ""
#End Region
#Region "Inventory Default Values..."
    Public INVQntyAvailability As String
    Public INVStockWarningMessage As String
    Public INVSalesOrderWarningMessage As String
    Public INVQntyDropShip As String
    Public INVQntyNonDropShip As String
    Public INVCustomField1 As String
    Public INVCustomField2 As String
    Public INVCustomField3 As String
    Public INVCustomField4 As String
    Public INVCustomField5 As String
    Public INVCustomFieldEnable1 As String
    Public INVCustomFieldEnable2 As String
    Public INVCustomFieldEnable3 As String
    Public INVCustomFieldEnable4 As String
    Public INVCustomFieldEnable5 As String
    Public INVStockGLSalesAccount As String
    Public INVStockGLInventoryAccount As String
    Public INVStockGLCostAccount As String
    Public INVStockCostingAccount As String
    Public INVMasterStockGLSalesAccount As String
    Public INVMasterStockGLInventoryAccount As String
    Public INVMasterStockGLCostAccount As String
    Public INVMasterStockCostingAccount As String
    Public INVNonStockGLSalesAccount As String
    Public INVNonStockGLInventoryAccount As String
    Public INVNonStockGLCostAccount As String
    Public INVNonStockCostingAccount As String
    Public INVDescriptionGLSalesAccount As String
    Public INVDescriptionGLInventoryAccount As String
    Public INVDescriptionGLCostAccount As String
    Public INVDescriptionCostingAccount As String
    Public INVServiceGLSalesAccount As String
    Public INVServiceGLInventoryAccount As String
    Public INVServiceGLCostAccount As String
    Public INVServiceCostingAccount As String
    Public INVLaborGLSalesAccount As String
    Public INVLaborGLInventoryAccount As String
    Public INVLaborGLCostAccount As String
    Public INVLaborCostingAccount As String
    Public INVAssemblyGLSalesAccount As String
    Public INVAssemblyGLInventoryAccount As String
    Public INVAssemblyGLCostAccount As String
    Public INVAssemblyCostingAccount As String
    Public INVActivityGLSalesAccount As String
    Public INVActivityGLInventoryAccount As String
    Public INVActivityGLCostAccount As String
    Public INVActivityCostingAccount As String
    Public INVChargedItemGLSalesAccount As String
    Public INVChargedItemGLInventoryAccount As String
    Public INVChargedItemGLCostAccount As String
    Public INVChargedItemCostingAccount As String
    Public INVGLFreightAccount As String
#End Region
End Module
