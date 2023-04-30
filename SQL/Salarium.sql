create database Salarium

use Salarium

create table Department
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
deptid Varchar(250),
deptname Varchar(250))

select * from Department 

create table Designation
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
desigid Varchar(250),
designame Varchar(250))

select * from Designation 

create table PayScale
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
pbname Varchar(250),
pblower float,
pbupper float,
pbgrade float,
pbbasic float,
payscale Varchar(250))

select * from PayScale 

create table DaHra
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
ID integer,
effectmonth integer,
effectyear integer,
darate float,
hrarate float,
maximum float,
medical float)

select * from DaHra 

create table ProfessionalTax
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
gross float,
taxrate float)

select * from ProfessionalTax 

create table PayslipHeaders
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
allowancedesc1 Varchar(250),
allowanceshortdesc1 Varchar(250),
allowancedesc2 Varchar(250),
allowanceshortdesc2 Varchar(250),
allowancedesc3 Varchar(250),
allowanceshortdesc3 Varchar(250),
allowancedesc4 Varchar(250),
allowanceshortdesc4 Varchar(250),
deductiondesc1 Varchar(250),
deductionshortdesc1 Varchar(250),
deductiondesc2 Varchar(250),
deductionshortdesc2 Varchar(250),
deductiondesc3 Varchar(250),
deductionshortdesc3 Varchar(250),
signatorydesc1 Varchar(250),
signatoryshortdesc1 Varchar(250),
signatorydesc2 Varchar(250),
signatoryshortdesc2 Varchar(250),
signatorydesc3 Varchar(250),
signatoryshortdesc3 Varchar(250))

select * from PayslipHeaders 

create table PFRate
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year integer,
rate float,
amount float)

select * from PFRate 

create table PFRateIndividual
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year integer,
regno Varchar(250),
name Varchar(250),
rate float,
amount float)

select * from PFRateIndividual 

create table AdjustmentDeductions
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
year integer,
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
thismonth integer,
lastmonth integer,
basicadjust float,
daadjust float,
hraadjust float,
otheradjust float,
ccsadjust float,
incometaxadjust float,
salaryadjust float,
conveyancealw float,
handicappedalw float,
washingalw float,
pfdeduction float,
conveyancealwrs float,
handicappedalwrs float,
washingalwrs float,
pfdeductionrs float,
specialpay float,
gslideduction float,
houserent float,
pfadvancerecovery float,
ccsloan float,
otherbankloan float,
festivaladvance float,
ccspo1loan float,
ccspo2loan float,
bankloan float,
ppfloan float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from AdjustmentDeductions 

create table WorkingHourly
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
empid Varchar(250),
name Varchar(250),
date Varchar(250),
starttime Varchar(250),
endtime Varchar(250),
totalminutes integer)

select * from WorkingHourly 

create table WorkingDaily
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
empid Varchar(250),
name Varchar(250),
date Varchar(250),
presentabsent Varchar(250))

select * from WorkingDaily 

create table Salary
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
year integer,
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
thismonth integer,
lastmonth integer,
basicadjust float,
daadjust float,
hraadjust float,
otheradjust float,
ccsadjust float,
incometaxadjust float,
salaryadjust float,
conveyancealw float,
handicappedalw float,
washingalw float,
pfdeduction float,
conveyancealwrs float,
handicappedalwrs float,
washingalwrs float,
pfdeductionrs float,
specialpay float,
gslideduction float,
houserent float,
pfadvancerecovery float,
ccsloan float,
otherbankloan float,
festivaladvance float,
ccspo1loan float,
ccspo2loan float,
bankloan float,
ppfloan float,
GetDA float,
GetArrier float,
GetHRA float,
DADeductThis float,
DADeductLast float,
DADeductionTotal float,
HRADeductThis float,
HRADeductLast float,
HRADeductTotal float,
DeductedMedical float,
ProfessionTax float,
TotalDeduction float,
TotalGain float,
NewBasic float,
EmployerPFDeduct float,
NetPay float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from Salary 

create table PayEmployee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
payslipno Varchar(250),
salarymonth Varchar(250),
salaryyear integer,
salarydate Varchar(250),
regno Varchar(250),
name Varchar(250),
designation Varchar(250),
payinfo Varchar(250),
getda float,
getarrier float,
gethra float,
tax float,
deduct float,
gain float,
newbasic float,
netpay float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from PayEmployee 

create table PF
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
joiningdate Varchar(250),
openingbalance float,
outstandingadvance float)

select * from PF 

create table PFAdvanceWithdrawal
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
regno Varchar(250),
name Varchar(250),
openingbalance float,
options Varchar(250),
amount float,
particulars Varchar(250))

select * from PFAdvanceWithdrawal 

create table CloseMembership
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
regno Varchar(250),
name Varchar(250),
closingbal float,
outstanding float,
closingdate Varchar(250))

select * from CloseMembership 