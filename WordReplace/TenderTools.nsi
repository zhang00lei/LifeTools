; 该脚本使用 HM VNISEdit 脚本编辑器向导产生

; 安装程序初始定义常量
!define PRODUCT_NAME "TenderTools"
!define PRODUCT_VERSION "1.0"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\TenderTools.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI 现代界面定义 (1.67 版本以上兼容) ------
!include "MUI.nsh"

; MUI 预定义常量
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; 欢迎页面
!insertmacro MUI_PAGE_WELCOME
; 安装目录选择页面
!insertmacro MUI_PAGE_DIRECTORY
; 安装过程页面
!insertmacro MUI_PAGE_INSTFILES
; 安装完成页面
!define MUI_FINISHPAGE_RUN "$INSTDIR\TenderTools.exe"
!insertmacro MUI_PAGE_FINISH

; 安装卸载过程页面
!insertmacro MUI_UNPAGE_INSTFILES

; 安装界面包含的语言设置
!insertmacro MUI_LANGUAGE "SimpChinese"

; 安装预释放文件
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI 现代界面定义结束 ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Setup.exe"
InstallDir "$PROGRAMFILES\TenderTools"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\TenderTools.exe"
  CreateDirectory "$SMPROGRAMS\TenderTools"
  CreateShortCut "$SMPROGRAMS\TenderTools\TenderTools.lnk" "$INSTDIR\TenderTools.exe"
  CreateShortCut "$DESKTOP\TenderTools.lnk" "$INSTDIR\TenderTools.exe"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\app_icon.ico"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\Microsoft.Office.Interop.Word.dll"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\office.dll"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\stdole.dll"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\TenderTools.pdb"
  SetOutPath "$INSTDIR\FindAndCopy"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\FindAndCopy\config.csv"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\FindAndCopy\Stat.txt"
  SetOutPath "$INSTDIR\ImgToWord"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\ImgToWord\config.csv"
  SetOutPath "$INSTDIR\ResetName"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\ResetName\config.csv"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\ResetName\Stat.txt"
  SetOutPath "$INSTDIR\WordReplaceInfo"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\WordReplaceInfo\config.csv"
  File "E:\LifeTools\WordReplace\WordReplace\bin\Debug\WordReplaceInfo\Stat.txt"
SectionEnd

Section -AdditionalIcons
  SetOutPath $INSTDIR
  CreateShortCut "$SMPROGRAMS\TenderTools\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\TenderTools.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\TenderTools.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
SectionEnd

/******************************
 *  以下是安装程序的卸载部分  *
 ******************************/

Section Uninstall
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\WordReplaceInfo\Stat.txt"
  Delete "$INSTDIR\WordReplaceInfo\config.csv"
  Delete "$INSTDIR\ResetName\Stat.txt"
  Delete "$INSTDIR\ResetName\config.csv"
  Delete "$INSTDIR\ImgToWord\config.csv"
  Delete "$INSTDIR\FindAndCopy\Stat.txt"
  Delete "$INSTDIR\FindAndCopy\config.csv"
  Delete "$INSTDIR\TenderTools.pdb"
  Delete "$INSTDIR\stdole.dll"
  Delete "$INSTDIR\office.dll"
  Delete "$INSTDIR\Microsoft.Office.Interop.Word.dll"
  Delete "$INSTDIR\app_icon.ico"
  Delete "$INSTDIR\TenderTools.exe"

  Delete "$SMPROGRAMS\TenderTools\Uninstall.lnk"
  Delete "$DESKTOP\TenderTools.lnk"
  Delete "$SMPROGRAMS\TenderTools\TenderTools.lnk"

  RMDir "$SMPROGRAMS\TenderTools"
  RMDir "$INSTDIR\WordReplaceInfo"
  RMDir "$INSTDIR\ResetName"
  RMDir "$INSTDIR\ImgToWord"
  RMDir "$INSTDIR\FindAndCopy"

  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd

#-- 根据 NSIS 脚本编辑规则，所有 Function 区段必须放置在 Section 区段之后编写，以避免安装程序出现未可预知的问题。--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "你确实要完全移除 $(^Name) ，及其所有的组件？" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) 已成功地从你的计算机移除。"
FunctionEnd
