

using MultiLevelPolymorphismExmp;

BankAccount ba = new BankAccount();
ba.accId = 100;
ba.accBal = 10000;
ba.accName = "Sai";
ba.accPhoneNum = "8801589631";
ba.accEmailId = "saikiran@gmail.com";
ba.MethodOverloading(2000);

SavingsAccount savings = new SavingsAccount();
savings.MethodOverriding(3000);

SalaryAccount sa = new SalaryAccount();
sa._companyName = "Accionlabs";
sa.DisplayDetails();

FixedDepositeAccount fda = new FixedDepositeAccount();
sa._companyName = "Accionlabs";
fda._accountType = "Fixed Deposite";
fda.DisplayDetails();

ReccuringDepositeAccount rda = new ReccuringDepositeAccount();
rda._companyName = "Accionlabs";
rda._accountType = "Reccuring Deposite";
rda.maxNumofHoldersPerAcc= 2;
rda.DisplayDetails();

















































//BankAccount ba = new BankAccount();
//ba.OverLoadigMethod(101, 10000, "sai kiran", "8801589631", "saikiran@gmail.com");
//ba.OverLoadigMethod(2000);

//SavingsAccount sa = new();
//sa.accountNum = ba.accountNum;
//sa.accountName = ba.accountName;
//sa.accHolderphoneNum = ba.accHolderphoneNum;
//sa.emailID = ba.emailID;
//sa.accountBal = ba.accountBal;
//sa.OvverridingMethod(6000);

//SalaryAccount salary = new SalaryAccount();

//salary.accountNum = sa.accountNum;
//salary.accountName = ba.accountName;
//salary.accHolderphoneNum = ba.accHolderphoneNum;
//salary.emailID = ba.emailID;
//salary.accountBal = sa.accountBal;
//salary.companyName = "Accionlabs";
//salary.DisplayDetails();

//FixedDepositeAccount fda = new FixedDepositeAccount();

//fda.accountType = "Fixed Deposite";
//fda.accountNum = salary.accountNum;
//fda.accountName = salary.accountName;
//fda.accHolderphoneNum = salary.accHolderphoneNum;
//fda.emailID = salary.emailID;
//fda.accountBal = salary.accountBal;
//fda.companyName = salary.companyName;
//fda.DisplayDetails();

//ReccuringDepositeAccount rda = new ReccuringDepositeAccount();

//rda.accountNum = fda.accountNum;
//rda.accountName = fda.accountName;
//rda.accHolderphoneNum = fda.accHolderphoneNum;
//rda.emailID = fda.emailID;
//rda.accountBal = fda.accountBal;
//rda.companyName = fda.companyName;
//rda.accountType = fda.accountType;
//rda.maxNumofHoldersPerAcc = 2;
//rda.DisplayDetails();