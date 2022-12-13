
#define MyAppName "Super Mario World MultiTools Launcher LTS"
#define MyShortAppName "SMW MultiTools Launcher LTS"
#define AppDataDirectoryName "SMW MultiTools Launcher LTS"
#define MyAppExeName "SMWMTL.exe"

#define MyAppVersion "2.10.1220.93"
#define MyShortAppVersion "2.10-LTS.14"

#define MyAppPublisher "AstragonQC Softwares"
#define MyAppURL "https://kiki79250.wixsite.com/smwmtl"

#define MyDateTimeString GetDateTimeString('yyyy', '', '')

[Setup]

; Application ID
AppId={{ADC1B674-5FED-4EAE-A809-47B87D8E878B}

; Application Infos
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#AppDataDirectoryName}

; External Links
;InfoBeforeFile=S:\SMWMTL Dev\SMW MultiTool Launcher\Resources - External\Setup\Files\RC_Warning.txt
LicenseFile=S:\SMWMTL Dev\SMW MultiTool Launcher\Resources - External\Setup\Files\LICENSE SMWMTL LTS.txt

SetupIconFile=S:\SMWMTL Dev\SMW MultiTool Launcher\Resources - External\Setup\Icons\Install_Icon.ico

WizardSmallImageFile=S:\SMWMTL Maintenance\InnoSetupFiles\WizModernSmallImage.bmp
WizardImageFile=S:\SMWMTL Maintenance\InnoSetupFiles\WizModernImage.bmp

; Export Infos
OutputDir=C:\Users\Kylian\Desktop
OutputBaseFilename=SMWMTL_{#MyShortAppVersion}_win64
VersionInfoVersion={#MyAppVersion}

AppCopyright=Copyright © 2018-{#MyDateTimeString} {#MyAppPublisher}
VersionInfoOriginalFileName=SMWMTL_{#MyShortAppVersion}_win64.exe
VersionInfoDescription={#MyShortAppName} v{#MyShortAppVersion} Setup

ArchitecturesAllowed=x64
MinVersion=0,6.0.6002

; Installer Options
WizardStyle=modern
WizardResizable=no
WizardSizePercent=150,100

DisableWelcomePage=no
DisableDirPage = no
DisableProgramGroupPage = no

; Uninstaller Options
UninstallDisplayName={#MyShortAppName}
UninstallDisplayIcon={app}\SMWMTL.exe

; Other Options
UsedUserAreasWarning=no

PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=commandline

Compression=lzma
SolidCompression=yes

; -------------------------------------------------

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked checkedonce
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked checkedonce; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "S:\SMWMTL Maintenance\Compilation\LTS\CompExe64\SMWMTL.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "S:\SMWMTL Maintenance\Compilation\LTS\x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "S:\SMWMTL Maintenance\Compilation\LTS\Common\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall
