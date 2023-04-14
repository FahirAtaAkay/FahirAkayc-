using OOP3;
using System;
using System.Collections.Generic;


ICreditManager propertyCreditManager = new PropertyCreditManager();
ICreditManager veichleCreditManager = new VeichleCreditManager();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Applicate(propertyCreditManager);
// kredimnager interface inde bir kredi türünü benden istedi
//
List<ICreditManager> credits = new List<ICreditManager>() {veichleCreditManager,propertyCreditManager };
applicationManager.CreditInformation(credits);
