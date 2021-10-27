; �ýű�ʹ�� HM VNISEdit �ű��༭���򵼲���

; ��װ�����ʼ���峣��
!define PRODUCT_NAME "TenderTools"
!define PRODUCT_VERSION "1.0"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\TenderTools.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI �ִ����涨�� (1.67 �汾���ϼ���) ------
!include "MUI.nsh"

; MUI Ԥ���峣��
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; ��ӭҳ��
!insertmacro MUI_PAGE_WELCOME
; ��װĿ¼ѡ��ҳ��
!insertmacro MUI_PAGE_DIRECTORY
; ��װ����ҳ��
!insertmacro MUI_PAGE_INSTFILES
; ��װ���ҳ��
!define MUI_FINISHPAGE_RUN "$INSTDIR\TenderTools.exe"
!insertmacro MUI_PAGE_FINISH

; ��װж�ع���ҳ��
!insertmacro MUI_UNPAGE_INSTFILES

; ��װ�����������������
!insertmacro MUI_LANGUAGE "SimpChinese"

; ��װԤ�ͷ��ļ�
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI �ִ����涨����� ------

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
 *  �����ǰ�װ�����ж�ز���  *
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

#-- ���� NSIS �ű��༭�������� Function ���α�������� Section ����֮���д���Ա��ⰲװ�������δ��Ԥ֪�����⡣--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "��ȷʵҪ��ȫ�Ƴ� $(^Name) ���������е������" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) �ѳɹ��ش���ļ�����Ƴ���"
FunctionEnd
