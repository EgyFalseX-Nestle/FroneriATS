;#DropDB FroneriATSEasyTest

#Application FroneriATS.Win
#Application FroneriATS.Web
#IfDef FroneriATS.Win

*Action About...
 
*Action OK

#EndIf

#IfDef FroneriATS.Web
*Action Navigation(My Details)
#EndIf
