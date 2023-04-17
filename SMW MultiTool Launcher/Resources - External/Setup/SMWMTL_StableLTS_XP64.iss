; MUST BE COMPILED USING INNO SETUP v5.6.1 ONLY, LATER VERSIONS WON'T WORK!

#define MyAppName "Super Mario World MultiTools Launcher LTS"
#define MyShortAppName "SMW MultiTools Launcher LTS"
#define AppDataDirectoryName "SMW MultiTools Launcher LTS"
#define MyAppExeName "SMWMTL.exe"

#define MyAppVersion "2.10.1221.101"
#define MyShortAppVersion "2.10-LTS.15"

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
DefaultDirName=C:\Documents and Settings\All Users\Application Data\{#AppDataDirectoryName}

; External Links
LicenseFile=S:\SMWMTL Dev\SMW MultiTool Launcher\Resources - External\Setup\Files\LICENSE SMWMTL LTS.txt

SetupIconFile=S:\SMWMTL Dev\SMW MultiTool Launcher\Resources - External\Setup\Icons\Install_Icon.ico

WizardSmallImageFile=S:\SMWMTL Maintenance\InnoSetupFiles\WizModernSmallImage.bmp
WizardImageFile=S:\SMWMTL Maintenance\InnoSetupFiles\WizModernImage.bmp

; Export Infos
OutputDir=C:\Users\Kylian\Desktop
OutputBaseFilename=SMWMTL_{#MyShortAppVersion}_win64_XPInstaller
VersionInfoVersion={#MyAppVersion}

AppCopyright=Copyright © 2018-{#MyDateTimeString} {#MyAppPublisher}
VersionInfoDescription={#MyShortAppName} v{#MyShortAppVersion} Setup

ArchitecturesAllowed=x64
MinVersion=0,5.2sp2

; Installer Options
DisableWelcomePage=no
DisableDirPage = no
DisableProgramGroupPage = no

; Uninstaller Options
UninstallDisplayName={#MyShortAppName}
UninstallDisplayIcon={app}\SMWMTL.exe

; Other Options
UsedUserAreasWarning=no    
PrivilegesRequired=lowest

Compression=lzma
SolidCompression=yes

; -------------------------------------------------

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked checkedonce
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "S:\SMWMTL Maintenance\Compilation\LTS\CompExe64\SMWMTL.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "S:\SMWMTL Maintenance\Compilation\LTS\x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "S:\SMWMTL Maintenance\Compilation\LTS\Common\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyShortAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall

; -------------------------------------------------

[CustomMessages]
english.OSCheckError=This version of the installer is for Windows XP only. Please download the normal version to install SMWMTL on Windows Vista and later.
french.OSCheckError=Cette version du programme d'installation est uniquement destinée à Windows XP. Veuillez télécharger la version normale pour installer SMWMTL sur Windows Vista et ultérieur.

[Code]
function IsWindowsVersionOrNewer(Major, Minor: Integer): Boolean;
var
  Version: TWindowsVersion;
begin
  GetWindowsVersionEx(Version);
  Result :=
    (Version.Major > Major) or
    ((Version.Major = Major) and (Version.Minor >= Minor));
end;

function IsWindowsXPOrNewer: Boolean;
begin
  Result := IsWindowsVersionOrNewer(5, 1);
end;

function IsWindowsVistaOrNewer: Boolean;
begin
  Result := IsWindowsVersionOrNewer(6, 0);
end;

function IsWindows7OrNewer: Boolean;
begin
  Result := IsWindowsVersionOrNewer(6, 1);
end;

function IsWindows8OrNewer: Boolean;
begin
  Result := IsWindowsVersionOrNewer(6, 2);
end;

function IsWindows10OrNewer: Boolean;
begin
  Result := IsWindowsVersionOrNewer(10, 0);
end;

// Windows 11 has the same major.minor as Windows 10.
// So it has to be distinguished by the Build.
// The IsWindows10OrNewer condition is actually redundant.
// Once we have to test for Windows 11 using the build number, we could actually
// unify and simplify all the tests above to use the build numbers only too.
function IsWindows11OrNewer: Boolean;
var
  Version: TWindowsVersion;
begin
  GetWindowsVersionEx(Version);
  Result := IsWindows10OrNewer and (Version.Build >= 22000);
end;

function InitializeSetup: Boolean;
begin
  if IsWindowsVistaOrNewer then
  begin 
    MsgBox(ExpandConstant('{cm:OSCheckError}'), mbCriticalError, MB_OK);
    Abort;
  end;  

  Result := True;
end;