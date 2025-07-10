/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = AssemblyInfo.cs                                                                                     */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2017, 2019, 2020, 2023, 2024 Renesas Electronics Corporation. All rights reserved.                    */
/*====================================================================================================================*/
/* Purpose: This file contains the functions to fill the  output file Msn_Cfg.h                                       */
/*                                                                                                                    */
/*====================================================================================================================*/
/*                                                                                                                    */
/* Unless otherwise agreed upon in writing between your company and Renesas Electronics Corporation the following     */
/* shall apply!                                                                                                       */
/*                                                                                                                    */
/* Warranty Disclaimer                                                                                                */
/*                                                                                                                    */
/* There is no warranty of any kind whatsoever granted by Renesas. Any warranty is expressly disclaimed and excluded  */
/* by Renesas, either expressed or implied, including but not limited to those for non-infringement of intellectual   */
/* property, merchantability and/or fitness for the particular purpose.                                               */
/*                                                                                                                    */
/* Renesas shall not have any obligation to maintain, service or provide bug fixes for the supplied Product(s) and/or */
/* the Application.                                                                                                   */
/*                                                                                                                    */
/* Each User is solely responsible for determining the appropriateness of using the Product(s) and assumes all risks  */
/* associated with its exercise of rights under this Agreement, including, but not limited to the risks and costs of  */
/* program errors, compliance with applicable laws, damage to or loss of data, programs or equipment, and             */
/* unavailability or interruption of operations.                                                                      */
/*                                                                                                                    */
/* Limitation of Liability                                                                                            */
/*                                                                                                                    */
/* In no event shall Renesas be liable to the User for any incidental, consequential, indirect, or punitive damage    */
/* (including but not limited to lost profits) regardless of whether such liability is based on breach of contract,   */
/* tort, strict liability, breach of warranties, failure of essential purpose or otherwise and even if advised of the */
/* possibility of such damages. Renesas shall not be liable for any services or products provided by third party      */
/* vendors, developers or consultants identified or referred to the User by Renesas in connection with the Product(s) */
/* and/or the Application.                                                                                            */
/*                                                                                                                    */
/*====================================================================================================================*/
/* Environment:                                                                                                       */
/*              Devices:       X2x                                                                                    */
/*====================================================================================================================*/
/* Classes      : This file contains the following class                                                              */

/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     20/09/2017   : Initial Version                                                                          */
/* 1.0.1:     29/01/2019   : Fix all bug from E2x FCC2 branch #87842                                                  */
/* 1.0.2:     07/02/2020   : Fix gentool unit test issue #249810                                                      */
/* 1.1.0:     22/06/2020   : Release                                                                                  */
/* 1.2.0:     26/08/2020   : Release                                                                                  */
/* 1.2.1:     07/03/2023   : Update AssemblyFileVerison to 1.4.0                                                      */
/* 1.2.2:     27/04/2023   : Update AssemblyFileVerison to 2.0.0                                                      */
/* 1.2.3:     22/09/2023   : Update AssemblyFileVerison to 2.0.1                                                      */
/* 1.2.4:     11/04/2024   : Update AssemblyFileVersion to 2.0.3                                                      */
/* 1.2.5:     21/05/2024   : Update AssemblyFileVersion to 2.1.1                                                      */
/* 1.2.6:     31/10/2024   : Update AssemblyFileVersion to 2.1.2                                                      */
/* 2.2.0:     31/12/2024   : Update AssemblyFileVersion for Ver22.02.00/Ver22.02.00.D Final Release                   */
/* 2.2.1:     31/12/2024   : Update SW Version for Ver22.00.01 U2Ax Release                                           */
/* 2.3.0:     31/01/2025   : Update SW Version for Ver22.00.06 U2Cx Release                                           */
/*====================================================================================================================*/

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MCALConfGen")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Renesas")]
[assembly: AssemblyProduct("MCALConfGen")]
[assembly: AssemblyCopyright("Copyright(c) 2018 - 2024 Renesas Electronics Corporation. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("d1fcd54e-251c-4221-9ff7-b56ea43c2a0e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("2.3.0")]
[assembly: InternalsVisibleTo("MCALConfGen.Tests")]
[assembly: InternalsVisibleTo("MCALConfGen.Fakes")]
[assembly: InternalsVisibleTo("TUT_GenericCommonize")]
