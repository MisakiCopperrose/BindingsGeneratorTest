using System.Runtime.InteropServices;
using InteropExtensions.C;

namespace LibClang.Net;
// Resharper disable all
public static unsafe class Clang
{
    private const string LibraryName = "clang";

    // Function @ CXString.h:50:28 (clang-c/CXString.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CString clang_getCString(CXString @string);

    // Function @ CXString.h:55:21 (clang-c/CXString.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeString(CXString @string);

    // Function @ CXString.h:60:21 (clang-c/CXString.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeStringSet(CXStringSet* set);

    // Function @ BuildSystem.h:33:35 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong clang_getBuildSessionTimestamp();

    // Function @ BuildSystem.h:48:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXVirtualFileOverlay clang_VirtualFileOverlay_create(uint options);

    // Function @ BuildSystem.h:56:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_VirtualFileOverlay_addFileMapping(CXVirtualFileOverlay param, CString virtualPath, CString realPath);

    // Function @ BuildSystem.h:67:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_VirtualFileOverlay_setCaseSensitivity(CXVirtualFileOverlay param, int caseSensitive);

    // Function @ BuildSystem.h:80:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_VirtualFileOverlay_writeToBuffer(CXVirtualFileOverlay param, uint options, CString* out_buffer_ptr, uint* out_buffer_size);

    // Function @ BuildSystem.h:90:21 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_free(void* buffer);

    // Function @ BuildSystem.h:95:21 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_VirtualFileOverlay_dispose(CXVirtualFileOverlay param);

    // Function @ BuildSystem.h:109:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXModuleMapDescriptor clang_ModuleMapDescriptor_create(uint options);

    // Function @ BuildSystem.h:116:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_ModuleMapDescriptor_setFrameworkModuleName(CXModuleMapDescriptor param, CString name);

    // Function @ BuildSystem.h:124:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_ModuleMapDescriptor_setUmbrellaHeader(CXModuleMapDescriptor param, CString name);

    // Function @ BuildSystem.h:137:1 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_ModuleMapDescriptor_writeToBuffer(CXModuleMapDescriptor param, uint options, CString* out_buffer_ptr, uint* out_buffer_size);

    // Function @ BuildSystem.h:144:21 (clang-c/BuildSystem.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_ModuleMapDescriptor_dispose(CXModuleMapDescriptor param);

    // Function @ Index.h:266:24 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIndex clang_createIndex(int excludeDeclarationsFromPCH, int displayDiagnostics);

    // Function @ Index.h:275:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeIndex(CXIndex index);

    // Function @ Index.h:324:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_CXIndex_setGlobalOptions(CXIndex param, uint options);

    // Function @ Index.h:332:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXIndex_getGlobalOptions(CXIndex param);

    // Function @ Index.h:342:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_CXIndex_setInvocationEmissionPathOption(CXIndex param, CString Path);

    // Function @ Index.h:358:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getFileName(CXFile SFile);

    // Function @ Index.h:363:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern time_t clang_getFileTime(CXFile SFile);

    // Function @ Index.h:381:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getFileUniqueID(CXFile file, CXFileUniqueID* outID);

    // Function @ Index.h:388:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isFileMultipleIncludeGuarded(CXTranslationUnit tu, CXFile file);

    // Function @ Index.h:401:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXFile clang_getFile(CXTranslationUnit tu, CString file_name);

    // Function @ Index.h:416:28 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CString clang_getFileContents(CXTranslationUnit tu, CXFile file, ulong* size);

    // Function @ Index.h:423:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_File_isEqual(CXFile file1, CXFile file2);

    // Function @ Index.h:430:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_File_tryGetRealPathName(CXFile file);

    // Function @ Index.h:476:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getNullLocation();

    // Function @ Index.h:486:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_equalLocations(CXSourceLocation loc1, CXSourceLocation loc2);

    // Function @ Index.h:493:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getLocation(CXTranslationUnit tu, CXFile file, uint line, uint column);

    // Function @ Index.h:500:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getLocationForOffset(CXTranslationUnit tu, CXFile file, uint offset);

    // Function @ Index.h:507:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Location_isInSystemHeader(CXSourceLocation location);

    // Function @ Index.h:513:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Location_isFromMainFile(CXSourceLocation location);

    // Function @ Index.h:518:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getNullRange();

    // Function @ Index.h:524:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getRange(CXSourceLocation begin, CXSourceLocation end);

    // Function @ Index.h:532:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_equalRanges(CXSourceRange range1, CXSourceRange range2);

    // Function @ Index.h:538:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Range_isNull(CXSourceRange range);

    // Function @ Index.h:562:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getExpansionLocation(CXSourceLocation location, CXFile* file, uint* line, uint* column, uint* offset);

    // Function @ Index.h:607:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getPresumedLocation(CXSourceLocation location, CXString* filename, uint* line, uint* column);

    // Function @ Index.h:619:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getInstantiationLocation(CXSourceLocation location, CXFile* file, uint* line, uint* column, uint* offset);

    // Function @ Index.h:646:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getSpellingLocation(CXSourceLocation location, CXFile* file, uint* line, uint* column, uint* offset);

    // Function @ Index.h:674:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getFileLocation(CXSourceLocation location, CXFile* file, uint* line, uint* column, uint* offset);

    // Function @ Index.h:682:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getRangeStart(CXSourceRange range);

    // Function @ Index.h:688:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getRangeEnd(CXSourceRange range);

    // Function @ Index.h:708:35 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRangeList* clang_getSkippedRanges(CXTranslationUnit tu, CXFile file);

    // Function @ Index.h:719:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRangeList* clang_getAllSkippedRanges(CXTranslationUnit tu);

    // Function @ Index.h:724:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeSourceRangeList(CXSourceRangeList* ranges);

    // Function @ Index.h:785:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getNumDiagnosticsInSet(CXDiagnosticSet Diags);

    // Function @ Index.h:796:29 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnostic clang_getDiagnosticInSet(CXDiagnosticSet Diags, uint Index);

    // Function @ Index.h:841:32 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnosticSet clang_loadDiagnostics(CString file, CXLoadDiag_Error* error, CXString* errorString);

    // Function @ Index.h:847:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeDiagnosticSet(CXDiagnosticSet Diags);

    // Function @ Index.h:855:32 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnosticSet clang_getChildDiagnostics(CXDiagnostic D);

    // Function @ Index.h:861:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getNumDiagnostics(CXTranslationUnit Unit);

    // Function @ Index.h:872:29 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnostic clang_getDiagnostic(CXTranslationUnit Unit, uint Index);

    // Function @ Index.h:882:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnosticSet clang_getDiagnosticSetFromTU(CXTranslationUnit Unit);

    // Function @ Index.h:887:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeDiagnostic(CXDiagnostic Diagnostic);

    // Function @ Index.h:972:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_formatDiagnostic(CXDiagnostic Diagnostic, uint Options);

    // Function @ Index.h:982:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_defaultDiagnosticDisplayOptions();

    // Function @ Index.h:988:5 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnosticSeverity clang_getDiagnosticSeverity(CXDiagnostic param);

    // Function @ Index.h:996:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getDiagnosticLocation(CXDiagnostic param);

    // Function @ Index.h:1001:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDiagnosticSpelling(CXDiagnostic param);

    // Function @ Index.h:1015:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDiagnosticOption(CXDiagnostic Diag, CXString* Disable);

    // Function @ Index.h:1028:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getDiagnosticCategory(CXDiagnostic param);

    // Function @ Index.h:1041:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDiagnosticCategoryName(uint Category);

    // Function @ Index.h:1048:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDiagnosticCategoryText(CXDiagnostic param);

    // Function @ Index.h:1054:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getDiagnosticNumRanges(CXDiagnostic param);

    // Function @ Index.h:1069:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getDiagnosticRange(CXDiagnostic Diagnostic, uint Range);

    // Function @ Index.h:1076:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getDiagnosticNumFixIts(CXDiagnostic Diagnostic);

    // Function @ Index.h:1103:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDiagnosticFixIt(CXDiagnostic Diagnostic, uint FixIt, CXSourceRange* ReplacementRange);

    // Function @ Index.h:1124:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getTranslationUnitSpelling(CXTranslationUnit CTUnit);

    // Function @ Index.h:1166:34 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTranslationUnit clang_createTranslationUnitFromSourceFile(CXIndex CIdx, CString source_filename, int num_clang_command_line_args, CString* clang_command_line_args, uint num_unsaved_files, CXUnsavedFile* unsaved_files);

    // Function @ Index.h:1178:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTranslationUnit clang_createTranslationUnit(CXIndex CIdx, CString ast_filename);

    // Function @ Index.h:1189:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_createTranslationUnit2(CXIndex CIdx, CString ast_filename, CXTranslationUnit* out_TU);

    // Function @ Index.h:1360:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_defaultEditingTranslationUnitOptions();

    // Function @ Index.h:1368:34 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTranslationUnit clang_parseTranslationUnit(CXIndex CIdx, CString source_filename, CString* command_line_args, int num_command_line_args, CXUnsavedFile* unsaved_files, uint num_unsaved_files, uint options);

    // Function @ Index.h:1418:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_parseTranslationUnit2(CXIndex CIdx, CString source_filename, CString* command_line_args, int num_command_line_args, CXUnsavedFile* unsaved_files, uint num_unsaved_files, uint options, CXTranslationUnit* out_TU);

    // Function @ Index.h:1429:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXErrorCode clang_parseTranslationUnit2FullArgv(CXIndex CIdx, CString source_filename, CString* command_line_args, int num_command_line_args, CXUnsavedFile* unsaved_files, uint num_unsaved_files, uint options, CXTranslationUnit* out_TU);

    // Function @ Index.h:1458:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_defaultSaveOptions(CXTranslationUnit TU);

    // Function @ Index.h:1518:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_saveTranslationUnit(CXTranslationUnit TU, CString FileName, uint options);

    // Function @ Index.h:1529:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_suspendTranslationUnit(CXTranslationUnit param);

    // Function @ Index.h:1534:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeTranslationUnit(CXTranslationUnit param);

    // Function @ Index.h:1560:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_defaultReparseOptions(CXTranslationUnit TU);

    // Function @ Index.h:1602:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_reparseTranslationUnit(CXTranslationUnit TU, uint num_unsaved_files, CXUnsavedFile* unsaved_files, uint options);

    // Function @ Index.h:1637:13 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CString clang_getTUResourceUsageName(CXTUResourceUsageKind kind);

    // Function @ Index.h:1668:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTUResourceUsage clang_getCXTUResourceUsage(CXTranslationUnit TU);

    // Function @ Index.h:1670:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeCXTUResourceUsage(CXTUResourceUsage usage);

    // Function @ Index.h:1678:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTargetInfo clang_getTranslationUnitTargetInfo(CXTranslationUnit CTUnit);

    // Function @ Index.h:1683:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_TargetInfo_dispose(CXTargetInfo Info);

    // Function @ Index.h:1690:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_TargetInfo_getTriple(CXTargetInfo Info);

    // Function @ Index.h:1697:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_TargetInfo_getPointerWidth(CXTargetInfo Info);

    // Function @ Index.h:2745:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getNullCursor();

    // Function @ Index.h:2753:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getTranslationUnitCursor(CXTranslationUnit param);

    // Function @ Index.h:2758:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_equalCursors(CXCursor param, CXCursor param2);

    // Function @ Index.h:2763:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_isNull(CXCursor cursor);

    // Function @ Index.h:2768:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_hashCursor(CXCursor param);

    // Function @ Index.h:2773:34 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursorKind clang_getCursorKind(CXCursor param);

    // Function @ Index.h:2778:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isDeclaration(CXCursorKind param);

    // Function @ Index.h:2788:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isInvalidDeclaration(CXCursor param);

    // Function @ Index.h:2798:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isReference(CXCursorKind param);

    // Function @ Index.h:2803:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isExpression(CXCursorKind param);

    // Function @ Index.h:2808:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isStatement(CXCursorKind param);

    // Function @ Index.h:2813:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isAttribute(CXCursorKind param);

    // Function @ Index.h:2818:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_hasAttrs(CXCursor C);

    // Function @ Index.h:2824:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isInvalid(CXCursorKind param);

    // Function @ Index.h:2830:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isTranslationUnit(CXCursorKind param);

    // Function @ Index.h:2836:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isPreprocessing(CXCursorKind param);

    // Function @ Index.h:2842:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isUnexposed(CXCursorKind param);

    // Function @ Index.h:2868:35 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXLinkageKind clang_getCursorLinkage(CXCursor cursor);

    // Function @ Index.h:2894:38 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXVisibilityKind clang_getCursorVisibility(CXCursor cursor);

    // Function @ Index.h:2905:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXAvailabilityKind clang_getCursorAvailability(CXCursor cursor);

    // Function @ Index.h:2980:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getCursorPlatformAvailability(CXCursor cursor, int* always_deprecated, CXString* deprecated_message, int* always_unavailable, CXString* unavailable_message, CXPlatformAvailability* availability, int availability_size);

    // Function @ Index.h:2989:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeCXPlatformAvailability(CXPlatformAvailability* availability);

    // Function @ Index.h:2995:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_Cursor_getVarDeclInitializer(CXCursor cursor);

    // Function @ Index.h:3002:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_hasVarDeclGlobalStorage(CXCursor cursor);

    // Function @ Index.h:3009:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_hasVarDeclExternalStorage(CXCursor cursor);

    // Function @ Index.h:3024:36 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXLanguageKind clang_getCursorLanguage(CXCursor cursor);

    // Function @ Index.h:3036:31 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTLSKind clang_getCursorTLSKind(CXCursor cursor);

    // Function @ Index.h:3041:34 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTranslationUnit clang_Cursor_getTranslationUnit(CXCursor param);

    // Function @ Index.h:3051:28 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursorSet clang_createCXCursorSet();

    // Function @ Index.h:3056:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeCXCursorSet(CXCursorSet cset);

    // Function @ Index.h:3063:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXCursorSet_contains(CXCursorSet cset, CXCursor cursor);

    // Function @ Index.h:3071:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXCursorSet_insert(CXCursorSet cset, CXCursor cursor);

    // Function @ Index.h:3107:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCursorSemanticParent(CXCursor cursor);

    // Function @ Index.h:3143:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCursorLexicalParent(CXCursor cursor);

    // Function @ Index.h:3188:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getOverriddenCursors(CXCursor cursor, CXCursor** overridden, uint* num_overridden);

    // Function @ Index.h:3196:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeOverriddenCursors(CXCursor* overridden);

    // Function @ Index.h:3202:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXFile clang_getIncludedFile(CXCursor cursor);

    // Function @ Index.h:3234:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCursor(CXTranslationUnit param, CXSourceLocation param2);

    // Function @ Index.h:3246:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getCursorLocation(CXCursor param);

    // Function @ Index.h:3259:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getCursorExtent(CXCursor param);

    // Function @ Index.h:3465:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getCursorType(CXCursor C);

    // Function @ Index.h:3473:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getTypeSpelling(CXType CT);

    // Function @ Index.h:3481:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getTypedefDeclUnderlyingType(CXCursor C);

    // Function @ Index.h:3489:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getEnumDeclIntegerType(CXCursor C);

    // Function @ Index.h:3499:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_getEnumConstantDeclValue(CXCursor C);

    // Function @ Index.h:3510:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong clang_getEnumConstantDeclUnsignedValue(CXCursor C);

    // Function @ Index.h:3517:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getFieldDeclBitWidth(CXCursor C);

    // Function @ Index.h:3526:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_getNumArguments(CXCursor C);

    // Function @ Index.h:3535:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_Cursor_getArgument(CXCursor C, uint i);

    // Function @ Index.h:3573:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_getNumTemplateArguments(CXCursor C);

    // Function @ Index.h:3592:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTemplateArgumentKind clang_Cursor_getTemplateArgumentKind(CXCursor C, uint I);

    // Function @ Index.h:3612:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Cursor_getTemplateArgumentType(CXCursor C, uint I);

    // Function @ Index.h:3632:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_Cursor_getTemplateArgumentValue(CXCursor C, uint I);

    // Function @ Index.h:3653:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong clang_Cursor_getTemplateArgumentUnsignedValue(CXCursor C, uint I);

    // Function @ Index.h:3661:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_equalTypes(CXType A, CXType B);

    // Function @ Index.h:3671:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getCanonicalType(CXType T);

    // Function @ Index.h:3678:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isConstQualifiedType(CXType T);

    // Function @ Index.h:3684:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isMacroFunctionLike(CXCursor C);

    // Function @ Index.h:3690:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isMacroBuiltin(CXCursor C);

    // Function @ Index.h:3696:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isFunctionInlined(CXCursor C);

    // Function @ Index.h:3703:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isVolatileQualifiedType(CXType T);

    // Function @ Index.h:3710:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isRestrictQualifiedType(CXType T);

    // Function @ Index.h:3715:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getAddressSpace(CXType T);

    // Function @ Index.h:3720:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getTypedefName(CXType CT);

    // Function @ Index.h:3725:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getPointeeType(CXType T);

    // Function @ Index.h:3730:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getTypeDeclaration(CXType T);

    // Function @ Index.h:3735:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getDeclObjCTypeEncoding(CXCursor C);

    // Function @ Index.h:3740:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Type_getObjCEncoding(CXType type);

    // Function @ Index.h:3745:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getTypeKindSpelling(CXTypeKind K);

    // Function @ Index.h:3752:35 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCallingConv clang_getFunctionTypeCallingConv(CXType T);

    // Function @ Index.h:3759:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getResultType(CXType T);

    // Function @ Index.h:3767:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getExceptionSpecificationType(CXType T);

    // Function @ Index.h:3775:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getNumArgTypes(CXType T);

    // Function @ Index.h:3783:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getArgType(CXType T, uint i);

    // Function @ Index.h:3790:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getObjCObjectBaseType(CXType T);

    // Function @ Index.h:3797:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Type_getNumObjCProtocolRefs(CXType T);

    // Function @ Index.h:3805:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_Type_getObjCProtocolDecl(CXType T, uint i);

    // Function @ Index.h:3812:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Type_getNumObjCTypeArgs(CXType T);

    // Function @ Index.h:3820:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getObjCTypeArg(CXType T, uint i);

    // Function @ Index.h:3825:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isFunctionTypeVariadic(CXType T);

    // Function @ Index.h:3832:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getCursorResultType(CXCursor C);

    // Function @ Index.h:3841:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_getCursorExceptionSpecificationType(CXCursor C);

    // Function @ Index.h:3847:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isPODType(CXType T);

    // Function @ Index.h:3855:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getElementType(CXType T);

    // Function @ Index.h:3863:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_getNumElements(CXType T);

    // Function @ Index.h:3870:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getArrayElementType(CXType T);

    // Function @ Index.h:3877:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_getArraySize(CXType T);

    // Function @ Index.h:3884:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getNamedType(CXType T);

    // Function @ Index.h:3894:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Type_isTransparentTagTypedef(CXType T);

    // Function @ Index.h:3929:43 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTypeNullabilityKind clang_Type_getNullability(CXType T);

    // Function @ Index.h:3978:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_Type_getAlignOf(CXType T);

    // Function @ Index.h:3985:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getClassType(CXType T);

    // Function @ Index.h:3996:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_Type_getSizeOf(CXType T);

    // Function @ Index.h:4011:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_Type_getOffsetOf(CXType T, CString S);

    // Function @ Index.h:4018:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getModifiedType(CXType T);

    // Function @ Index.h:4025:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getValueType(CXType CT);

    // Function @ Index.h:4040:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_Cursor_getOffsetOfField(CXCursor C);

    // Function @ Index.h:4046:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isAnonymous(CXCursor C);

    // Function @ Index.h:4052:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isAnonymousRecordDecl(CXCursor C);

    // Function @ Index.h:4058:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isInlineNamespace(CXCursor C);

    // Function @ Index.h:4073:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Type_getNumTemplateArguments(CXType T);

    // Function @ Index.h:4082:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Type_getTemplateArgumentAsType(CXType T, uint i);

    // Function @ Index.h:4091:40 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXRefQualifierKind clang_Type_getCXXRefQualifier(CXType T);

    // Function @ Index.h:4097:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isBitField(CXCursor C);

    // Function @ Index.h:4103:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isVirtualBase(CXCursor param);

    // Function @ Index.h:4123:43 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CX_CXXAccessSpecifier clang_getCXXAccessSpecifier(CXCursor param);

    // Function @ Index.h:4146:37 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CX_StorageClass clang_Cursor_getStorageClass(CXCursor param);

    // Function @ Index.h:4157:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getNumOverloadedDecls(CXCursor cursor);

    // Function @ Index.h:4173:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getOverloadedDecl(CXCursor cursor, uint index);

    // Function @ Index.h:4191:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_getIBOutletCollectionType(CXCursor param);

    // // Function @ Index.h:4268:25 (clang-c/Index.h)
    // [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    // public static extern uint clang_visitChildren(CXCursor parent, CXCursorVisitor visitor, CXClientData client_data);
    
    // Function @ Index.h:4268:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_visitChildren(CXCursor parent, nint visitor, CXClientData client_data);

    // Function @ Index.h:4319:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCursorUSR(CXCursor param);

    // Function @ Index.h:4324:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCClass(CString class_name);

    // Function @ Index.h:4329:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCCategory(CString class_name, CString category_name);

    // Function @ Index.h:4336:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCProtocol(CString protocol_name);

    // Function @ Index.h:4342:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCIvar(CString name, CXString classUSR);

    // Function @ Index.h:4349:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCMethod(CString name, uint isInstanceMethod, CXString classUSR);

    // Function @ Index.h:4357:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_constructUSR_ObjCProperty(CString property, CXString classUSR);

    // Function @ Index.h:4363:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCursorSpelling(CXCursor param);

    // Function @ Index.h:4376:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_Cursor_getSpellingNameRange(CXCursor param, uint pieceIndex, uint options);

    // Function @ Index.h:4425:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_PrintingPolicy_getProperty(CXPrintingPolicy Policy, CXPrintingPolicyProperty Property);

    // Function @ Index.h:4432:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_PrintingPolicy_setProperty(CXPrintingPolicy Policy, CXPrintingPolicyProperty Property, uint Value);

    // Function @ Index.h:4442:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXPrintingPolicy clang_getCursorPrintingPolicy(CXCursor param);

    // Function @ Index.h:4447:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_PrintingPolicy_dispose(CXPrintingPolicy Policy);

    // Function @ Index.h:4460:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCursorPrettyPrinted(CXCursor Cursor, CXPrintingPolicy Policy);

    // Function @ Index.h:4470:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCursorDisplayName(CXCursor param);

    // Function @ Index.h:4482:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCursorReferenced(CXCursor param);

    // Function @ Index.h:4512:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCursorDefinition(CXCursor param);

    // Function @ Index.h:4518:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_isCursorDefinition(CXCursor param);

    // Function @ Index.h:4544:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getCanonicalCursor(CXCursor param);

    // Function @ Index.h:4557:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_getObjCSelectorIndex(CXCursor param);

    // Function @ Index.h:4570:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Cursor_isDynamicCall(CXCursor C);

    // Function @ Index.h:4576:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXType clang_Cursor_getReceiverType(CXCursor C);

    // Function @ Index.h:4606:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_getObjCPropertyAttributes(CXCursor C, uint reserved);

    // Function @ Index.h:4612:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Cursor_getObjCPropertyGetterName(CXCursor C);

    // Function @ Index.h:4618:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Cursor_getObjCPropertySetterName(CXCursor C);

    // Function @ Index.h:4640:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_getObjCDeclQualifiers(CXCursor C);

    // Function @ Index.h:4647:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isObjCOptional(CXCursor C);

    // Function @ Index.h:4652:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isVariadic(CXCursor C);

    // Function @ Index.h:4667:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Cursor_isExternalSymbol(CXCursor C, CXString* language, CXString* definedIn, uint* isGenerated);

    // Function @ Index.h:4677:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_Cursor_getCommentRange(CXCursor C);

    // Function @ Index.h:4683:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Cursor_getRawCommentText(CXCursor C);

    // Function @ Index.h:4690:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Cursor_getBriefCommentText(CXCursor C);

    // Function @ Index.h:4704:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Cursor_getMangling(CXCursor param);

    // Function @ Index.h:4710:29 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXStringSet* clang_Cursor_getCXXManglings(CXCursor param);

    // Function @ Index.h:4716:29 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXStringSet* clang_Cursor_getObjCManglings(CXCursor param);

    // Function @ Index.h:4735:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXModule clang_Cursor_getModule(CXCursor C);

    // Function @ Index.h:4741:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXModule clang_getModuleForFile(CXTranslationUnit param, CXFile param2);

    // Function @ Index.h:4748:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXFile clang_Module_getASTFile(CXModule Module);

    // Function @ Index.h:4756:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXModule clang_Module_getParent(CXModule Module);

    // Function @ Index.h:4764:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Module_getName(CXModule Module);

    // Function @ Index.h:4771:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_Module_getFullName(CXModule Module);

    // Function @ Index.h:4778:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_Module_isSystem(CXModule Module);

    // Function @ Index.h:4785:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Module_getNumTopLevelHeaders(CXTranslationUnit param, CXModule Module);

    // Function @ Index.h:4796:8 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXFile clang_Module_getTopLevelHeader(CXTranslationUnit param, CXModule Module, uint Index);

    // Function @ Index.h:4816:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXConstructor_isConvertingConstructor(CXCursor C);

    // Function @ Index.h:4821:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXConstructor_isCopyConstructor(CXCursor C);

    // Function @ Index.h:4826:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXConstructor_isDefaultConstructor(CXCursor C);

    // Function @ Index.h:4831:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXConstructor_isMoveConstructor(CXCursor C);

    // Function @ Index.h:4836:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXField_isMutable(CXCursor C);

    // Function @ Index.h:4841:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXMethod_isDefaulted(CXCursor C);

    // Function @ Index.h:4847:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXMethod_isPureVirtual(CXCursor C);

    // Function @ Index.h:4853:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXMethod_isStatic(CXCursor C);

    // Function @ Index.h:4860:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXMethod_isVirtual(CXCursor C);

    // Function @ Index.h:4866:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXRecord_isAbstract(CXCursor C);

    // Function @ Index.h:4871:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_EnumDecl_isScoped(CXCursor C);

    // Function @ Index.h:4877:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_CXXMethod_isConst(CXCursor C);

    // Function @ Index.h:4896:34 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursorKind clang_getTemplateCursorKind(CXCursor C);

    // Function @ Index.h:4926:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursor clang_getSpecializedCursorTemplate(CXCursor C);

    // Function @ Index.h:4946:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getCursorReferenceNameRange(CXCursor C, uint NameFlags, uint PieceIndex);

    // Function @ Index.h:5038:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXToken* clang_getToken(CXTranslationUnit TU, CXSourceLocation Location);

    // Function @ Index.h:5044:28 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXTokenKind clang_getTokenKind(CXToken param);

    // Function @ Index.h:5052:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getTokenSpelling(CXTranslationUnit param, CXToken param2);

    // Function @ Index.h:5057:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_getTokenLocation(CXTranslationUnit param, CXToken param2);

    // Function @ Index.h:5063:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceRange clang_getTokenExtent(CXTranslationUnit param, CXToken param2);

    // Function @ Index.h:5082:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_tokenize(CXTranslationUnit TU, CXSourceRange Range, CXToken** Tokens, uint* NumTokens);

    // Function @ Index.h:5115:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_annotateTokens(CXTranslationUnit TU, CXToken* Tokens, uint NumTokens, CXCursor* Cursors);

    // Function @ Index.h:5121:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeTokens(CXTranslationUnit TU, CXToken* Tokens, uint NumTokens);

    // Function @ Index.h:5138:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCursorKindSpelling(CXCursorKind Kind);

    // Function @ Index.h:5139:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getDefinitionSpellingAndExtent(CXCursor param, CString* startBuf, CString* endBuf, uint* startLine, uint* startColumn, uint* endLine, uint* endColumn);

    // Function @ Index.h:5142:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_enableStackTraces();

    // Function @ Index.h:5143:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_executeOnThread(FnPtr_VoidPtr_Void fn, void* user_data, uint stack_size);

    // Function @ Index.h:5381:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCompletionChunkKind clang_getCompletionChunkKind(CXCompletionString completion_string, uint chunk_number);

    // Function @ Index.h:5394:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCompletionChunkText(CXCompletionString completion_string, uint chunk_number);

    // Function @ Index.h:5408:35 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCompletionString clang_getCompletionChunkCompletionString(CXCompletionString completion_string, uint chunk_number);

    // Function @ Index.h:5415:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getNumCompletionChunks(CXCompletionString completion_string);

    // Function @ Index.h:5430:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getCompletionPriority(CXCompletionString completion_string);

    // Function @ Index.h:5441:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXAvailabilityKind clang_getCompletionAvailability(CXCompletionString completion_string);

    // Function @ Index.h:5453:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getCompletionNumAnnotations(CXCompletionString completion_string);

    // Function @ Index.h:5466:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCompletionAnnotation(CXCompletionString completion_string, uint annotation_number);

    // Function @ Index.h:5485:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCompletionParent(CXCompletionString completion_string, CXCursorKind* kind);

    // Function @ Index.h:5493:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCompletionBriefComment(CXCompletionString completion_string);

    // Function @ Index.h:5505:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCompletionString clang_getCursorCompletionString(CXCursor cursor);

    // Function @ Index.h:5541:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_getCompletionNumFixIts(CXCodeCompleteResults* results, uint completion_index);

    // Function @ Index.h:5587:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getCompletionFixIt(CXCodeCompleteResults* results, uint completion_index, uint fixit_index, CXSourceRange* replacement_range);

    // Function @ Index.h:5771:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_defaultCodeCompleteOptions();

    // Function @ Index.h:5843:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCodeCompleteResults* clang_codeCompleteAt(CXTranslationUnit TU, CString complete_filename, uint complete_line, uint complete_column, CXUnsavedFile* unsaved_files, uint num_unsaved_files, uint options);

    // Function @ Index.h:5856:6 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_sortCodeCompletionResults(CXCompletionResult* Results, uint NumResults);

    // Function @ Index.h:5863:6 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_disposeCodeCompleteResults(CXCodeCompleteResults* Results);

    // Function @ Index.h:5870:10 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_codeCompleteGetNumDiagnostics(CXCodeCompleteResults* Results);

    // Function @ Index.h:5882:14 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXDiagnostic clang_codeCompleteGetDiagnostic(CXCodeCompleteResults* Results, uint Index);

    // Function @ Index.h:5896:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong clang_codeCompleteGetContexts(CXCodeCompleteResults* Results);

    // Function @ Index.h:5916:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXCursorKind clang_codeCompleteGetContainerKind(CXCodeCompleteResults* Results, uint* IsIncomplete);

    // Function @ Index.h:5929:10 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_codeCompleteGetContainerUSR(CXCodeCompleteResults* Results);

    // Function @ Index.h:5943:10 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_codeCompleteGetObjCSelector(CXCodeCompleteResults* Results);

    // Function @ Index.h:5959:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXString clang_getClangVersion();

    // Function @ Index.h:5967:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_toggleCrashRecovery(uint isEnabled);

    // Function @ Index.h:5991:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_getInclusions(CXTranslationUnit tu, CXInclusionVisitor visitor, CXClientData client_data);

    // Function @ Index.h:6018:29 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXEvalResult clang_Cursor_Evaluate(CXCursor C);

    // Function @ Index.h:6023:33 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXEvalResultKind clang_EvalResult_getKind(CXEvalResult E);

    // Function @ Index.h:6029:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_EvalResult_getAsInt(CXEvalResult E);

    // Function @ Index.h:6036:26 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern long clang_EvalResult_getAsLongLong(CXEvalResult E);

    // Function @ Index.h:6042:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_EvalResult_isUnsignedInt(CXEvalResult E);

    // Function @ Index.h:6049:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong clang_EvalResult_getAsUnsigned(CXEvalResult E);

    // Function @ Index.h:6055:23 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double clang_EvalResult_getAsDouble(CXEvalResult E);

    // Function @ Index.h:6063:28 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CString clang_EvalResult_getAsStr(CXEvalResult E);

    // Function @ Index.h:6068:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_EvalResult_dispose(CXEvalResult E);

    // Function @ Index.h:6091:28 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXRemapping clang_getRemappings(CString path);

    // Function @ Index.h:6104:13 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXRemapping clang_getRemappingsFromFileList(CString* filePaths, uint numFiles);

    // Function @ Index.h:6110:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_remap_getNumFiles(CXRemapping param);

    // Function @ Index.h:6120:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_remap_getFilenames(CXRemapping param, uint index, CXString* original, CXString* transformed);

    // Function @ Index.h:6127:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_remap_dispose(CXRemapping param);

    // Function @ Index.h:6176:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXResult clang_findReferencesInFile(CXCursor cursor, CXFile file, CXCursorAndRangeVisitor visitor);

    // Function @ Index.h:6191:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXResult clang_findIncludesInFile(CXTranslationUnit TU, CXFile file, CXCursorAndRangeVisitor visitor);

    // Function @ Index.h:6592:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_index_isEntityObjCContainerKind(CXIdxEntityKind param);

    // Function @ Index.h:6594:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxObjCContainerDeclInfo* clang_index_getObjCContainerDeclInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6597:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxObjCInterfaceDeclInfo* clang_index_getObjCInterfaceDeclInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6601:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxObjCCategoryDeclInfo* clang_index_getObjCCategoryDeclInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6604:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxObjCProtocolRefListInfo* clang_index_getObjCProtocolRefListInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6607:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxObjCPropertyDeclInfo* clang_index_getObjCPropertyDeclInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6610:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxIBOutletCollectionAttrInfo* clang_index_getIBOutletCollectionAttrInfo(CXIdxAttrInfo* param);

    // Function @ Index.h:6613:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxCXXClassDeclInfo* clang_index_getCXXClassDeclInfo(CXIdxDeclInfo* param);

    // Function @ Index.h:6620:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxClientContainer clang_index_getClientContainer(CXIdxContainerInfo* param);

    // Function @ Index.h:6626:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_index_setClientContainer(CXIdxContainerInfo* param, CXIdxClientContainer param2);

    // Function @ Index.h:6633:1 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIdxClientEntity clang_index_getClientEntity(CXIdxEntityInfo* param);

    // Function @ Index.h:6638:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_index_setClientEntity(CXIdxEntityInfo* param, CXIdxClientEntity param2);

    // Function @ Index.h:6653:30 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXIndexAction clang_IndexAction_create(CXIndex CIdx);

    // Function @ Index.h:6661:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_IndexAction_dispose(CXIndexAction param);

    // Function @ Index.h:6727:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_indexSourceFile(CXIndexAction param, CXClientData client_data, IndexerCallbacks* index_callbacks, uint index_callbacks_size, uint index_options, CString source_filename, CString* command_line_args, int num_command_line_args, CXUnsavedFile* unsaved_files, uint num_unsaved_files, CXTranslationUnit* out_TU, uint TU_options);

    // Function @ Index.h:6739:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_indexSourceFileFullArgv(CXIndexAction param, CXClientData client_data, IndexerCallbacks* index_callbacks, uint index_callbacks_size, uint index_options, CString source_filename, CString* command_line_args, int num_command_line_args, CXUnsavedFile* unsaved_files, uint num_unsaved_files, CXTranslationUnit* out_TU, uint TU_options);

    // Function @ Index.h:6762:20 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int clang_indexTranslationUnit(CXIndexAction param, CXClientData client_data, IndexerCallbacks* index_callbacks, uint index_callbacks_size, uint index_options, CXTranslationUnit param2);

    // Function @ Index.h:6774:21 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void clang_indexLoc_getFileLocation(CXIdxLoc loc, CXIdxClientFile* indexFile, CXFile* file, uint* line, uint* column, uint* offset);

    // Function @ Index.h:6784:18 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern CXSourceLocation clang_indexLoc_getCXSourceLocation(CXIdxLoc loc);

    // Function @ Index.h:6819:25 (clang-c/Index.h)
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
    public static extern uint clang_Type_visitFields(CXType T, CXFieldVisitor visitor, CXClientData client_data);

    // FunctionPointer @ Index.h:4242:35 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXCursorVisitor
    {
        public delegate* unmanaged<CXCursor, CXCursor, CXClientData, CXChildVisitResult> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_Void
    {
        public delegate* unmanaged<void*, void> Pointer;
    }

    // FunctionPointer @ Index.h:5980:16 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXInclusionVisitor
    {
        public delegate* unmanaged<CXFile, CXSourceLocation*, uint, CXClientData, void> Pointer;
    }

    // FunctionPointer @ Index.h:6797:32 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXFieldVisitor
    {
        public delegate* unmanaged<CXCursor, CXClientData, CXVisitorResult> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_CXCursor_CXSourceRange_CXVisitorResult
    {
        public delegate* unmanaged<void*, CXCursor, CXSourceRange, CXVisitorResult> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXIdxEntityRefInfoPtr_Void
    {
        public delegate* unmanaged<CXClientData, CXIdxEntityRefInfo*, void> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXIdxDeclInfoPtr_Void
    {
        public delegate* unmanaged<CXClientData, CXIdxDeclInfo*, void> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_VoidPtr_CXIdxClientContainer
    {
        public delegate* unmanaged<CXClientData, void*, CXIdxClientContainer> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXIdxImportedASTFileInfoPtr_CXIdxClientASTFile
    {
        public delegate* unmanaged<CXClientData, CXIdxImportedASTFileInfo*, CXIdxClientASTFile> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXIdxIncludedFileInfoPtr_CXIdxClientFile
    {
        public delegate* unmanaged<CXClientData, CXIdxIncludedFileInfo*, CXIdxClientFile> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXFile_VoidPtr_CXIdxClientFile
    {
        public delegate* unmanaged<CXClientData, CXFile, void*, CXIdxClientFile> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_CXDiagnosticSet_VoidPtr_Void
    {
        public delegate* unmanaged<CXClientData, CXDiagnosticSet, void*, void> Pointer;
    }

    // FunctionPointer @ Null
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CXClientData_VoidPtr_Int
    {
        public delegate* unmanaged<CXClientData, void*, int> Pointer;
    }

    // Struct @ CXString.h:40:3 (clang-c/CXString.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXString
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* data;

        [FieldOffset(8)] // size = 4, padding = 4
        public uint private_flags;
    }

    // Struct @ CXString.h:45:3 (clang-c/CXString.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXStringSet
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXString* Strings;

        [FieldOffset(8)] // size = 4, padding = 4
        public uint Count;
    }

    // Struct @ Index.h:371:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXFileUniqueID
    {
        [FieldOffset(0)] // size = 24, padding = 0
        public fixed byte _data[24]; // unsigned long long[3]

        public Span<ulong> data
        {
            get
            {
                fixed (CXFileUniqueID* @this = &this)
                {
                    var pointer = &@this->_data[0];
                    var span = new Span<ulong>(pointer, 3);
                    return span;
                }
            }
        }
    }

    // Struct @ Index.h:459:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXSourceLocation
    {
        [FieldOffset(0)] // size = 16, padding = 0
        public fixed byte _ptr_data[16]; // void*[2]

        public Span<nint> ptr_data
        {
            get
            {
                fixed (CXSourceLocation* @this = &this)
                {
                    var pointer = &@this->_ptr_data[0];
                    var span = new Span<nint>(pointer, 2);
                    return span;
                }
            }
        }

        [FieldOffset(16)] // size = 4, padding = 4
        public uint int_data;
    }

    // Struct @ Index.h:471:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXSourceRange
    {
        [FieldOffset(0)] // size = 16, padding = 0
        public fixed byte _ptr_data[16]; // void*[2]

        public Span<nint> ptr_data
        {
            get
            {
                fixed (CXSourceRange* @this = &this)
                {
                    var pointer = &@this->_ptr_data[0];
                    var span = new Span<nint>(pointer, 2);
                    return span;
                }
            }
        }

        [FieldOffset(16)] // size = 4, padding = 0
        public uint begin_int_data;

        [FieldOffset(20)] // size = 4, padding = 0
        public uint end_int_data;
    }

    // Struct @ Index.h:700:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXSourceRangeList
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public uint count;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXSourceRange* ranges;
    }

    // Struct @ Index.h:101:8 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXUnsavedFile
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CString Filename;

        [FieldOffset(8)] // size = 8, padding = 0
        public CString Contents;

        [FieldOffset(16)] // size = 8, padding = 0
        public ulong Length;
    }

    // Struct @ Index.h:1661:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXTUResourceUsage
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* data;

        [FieldOffset(8)] // size = 4, padding = 4
        public uint numEntries;

        [FieldOffset(16)] // size = 8, padding = 0
        public CXTUResourceUsageEntry* entries;
    }

    // Struct @ Index.h:2734:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public struct CXCursor
    {
        [FieldOffset(0)] // size = 4, padding = 0
        public CXCursorKind kind;

        [FieldOffset(4)] // size = 4, padding = 0
        public int xdata;

        [FieldOffset(8)] // size = 24, padding = 0
        public fixed byte _data[24]; // void*[3]

        public Span<nint> data
        {
            get
            {
                fixed (CXCursor* @this = &this)
                {
                    var pointer = &@this->_data[0];
                    var span = new Span<nint>(pointer, 3);
                    return span;
                }
            }
        }
    }

    // Struct @ Index.h:2942:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 72, Pack = 8)]
    public struct CXPlatformAvailability
    {
        [FieldOffset(0)] // size = 16, padding = 0
        public CXString Platform;

        [FieldOffset(16)] // size = 12, padding = 0
        public CXVersion Introduced;

        [FieldOffset(28)] // size = 12, padding = 0
        public CXVersion Deprecated;

        [FieldOffset(40)] // size = 12, padding = 0
        public CXVersion Obsoleted;

        [FieldOffset(52)] // size = 4, padding = 0
        public int Unavailable;

        [FieldOffset(56)] // size = 16, padding = 0
        public CXString Message;
    }

    // Struct @ Index.h:3460:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXType
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public CXTypeKind kind;

        [FieldOffset(8)] // size = 16, padding = 0
        public fixed byte _data[16]; // void*[2]

        public Span<nint> data
        {
            get
            {
                fixed (CXType* @this = &this)
                {
                    var pointer = &@this->_data[0];
                    var span = new Span<nint>(pointer, 2);
                    return span;
                }
            }
        }
    }

    // Struct @ Index.h:5025:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXToken
    {
        [FieldOffset(0)] // size = 16, padding = 0
        public fixed byte _int_data[16]; // unsigned int[4]

        public Span<uint> int_data
        {
            get
            {
                fixed (CXToken* @this = &this)
                {
                    var pointer = &@this->_int_data[0];
                    var span = new Span<uint>(pointer, 4);
                    return span;
                }
            }
        }

        [FieldOffset(16)] // size = 8, padding = 0
        public void* ptr_data;
    }

    // Struct @ Index.h:5525:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXCodeCompleteResults
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXCompletionResult* Results;

        [FieldOffset(8)] // size = 4, padding = 4
        public uint NumResults;
    }

    // Struct @ Index.h:5198:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXCompletionResult
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public CXCursorKind CursorKind;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXCompletionString CompletionString;
    }

    // Struct @ Index.h:6143:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXCursorAndRangeVisitor
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* context;

        [FieldOffset(8)] // size = 8, padding = 0
        public FnPtr_VoidPtr_CXCursor_CXSourceRange_CXVisitorResult visit;
    }

    // Struct @ Index.h:6422:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXIdxObjCContainerDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxDeclInfo* declInfo;

        [FieldOffset(8)] // size = 4, padding = 4
        public CXIdxObjCContainerKind kind;
    }

    // Struct @ Index.h:6411:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 128, Pack = 8)]
    public struct CXIdxDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxEntityInfo* entityInfo;

        [FieldOffset(8)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(40)] // size = 24, padding = 0
        public CXIdxLoc loc;

        [FieldOffset(64)] // size = 8, padding = 0
        public CXIdxContainerInfo* semanticContainer;

        [FieldOffset(72)] // size = 8, padding = 0
        public CXIdxContainerInfo* lexicalContainer;

        [FieldOffset(80)] // size = 4, padding = 0
        public int isRedeclaration;

        [FieldOffset(84)] // size = 4, padding = 0
        public int isDefinition;

        [FieldOffset(88)] // size = 4, padding = 4
        public int isContainer;

        [FieldOffset(96)] // size = 8, padding = 0
        public CXIdxContainerInfo* declAsContainer;

        [FieldOffset(104)] // size = 4, padding = 4
        public int isImplicit;

        [FieldOffset(112)] // size = 8, padding = 0
        public CXIdxAttrInfo** attributes;

        [FieldOffset(120)] // size = 4, padding = 0
        public uint numAttributes;

        [FieldOffset(124)] // size = 4, padding = 0
        public uint flags;
    }

    // Struct @ Index.h:6445:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXIdxObjCInterfaceDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxObjCContainerDeclInfo* containerInfo;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXIdxBaseClassInfo* superInfo;

        [FieldOffset(16)] // size = 8, padding = 0
        public CXIdxObjCProtocolRefListInfo* protocols;
    }

    // Struct @ Index.h:6453:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 80, Pack = 8)]
    public struct CXIdxObjCCategoryDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxObjCContainerDeclInfo* containerInfo;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXIdxEntityInfo* objcClass;

        [FieldOffset(16)] // size = 32, padding = 0
        public CXCursor classCursor;

        [FieldOffset(48)] // size = 24, padding = 0
        public CXIdxLoc classLoc;

        [FieldOffset(72)] // size = 8, padding = 0
        public CXIdxObjCProtocolRefListInfo* protocols;
    }

    // Struct @ Index.h:6439:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXIdxObjCProtocolRefListInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxObjCProtocolRefInfo** protocols;

        [FieldOffset(8)] // size = 4, padding = 4
        public uint numProtocols;
    }

    // Struct @ Index.h:6459:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXIdxObjCPropertyDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxDeclInfo* declInfo;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXIdxEntityInfo* getter;

        [FieldOffset(16)] // size = 8, padding = 0
        public CXIdxEntityInfo* setter;
    }

    // Struct @ Index.h:6383:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 72, Pack = 8)]
    public struct CXIdxIBOutletCollectionAttrInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxAttrInfo* attrInfo;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXIdxEntityInfo* objcClass;

        [FieldOffset(16)] // size = 32, padding = 0
        public CXCursor classCursor;

        [FieldOffset(48)] // size = 24, padding = 0
        public CXIdxLoc classLoc;
    }

    // Struct @ Index.h:6361:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
    public struct CXIdxAttrInfo
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public CXIdxAttrKind kind;

        [FieldOffset(8)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(40)] // size = 24, padding = 0
        public CXIdxLoc loc;
    }

    // Struct @ Index.h:6465:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXIdxCXXClassDeclInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxDeclInfo* declInfo;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXIdxBaseClassInfo** bases;

        [FieldOffset(16)] // size = 4, padding = 4
        public uint numBases;
    }

    // Struct @ Index.h:6376:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public struct CXIdxContainerInfo
    {
        [FieldOffset(0)] // size = 32, padding = 0
        public CXCursor cursor;
    }

    // Struct @ Index.h:6372:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 80, Pack = 8)]
    public struct CXIdxEntityInfo
    {
        [FieldOffset(0)] // size = 4, padding = 0
        public CXIdxEntityKind kind;

        [FieldOffset(4)] // size = 4, padding = 0
        public CXIdxEntityCXXTemplateKind templateKind;

        [FieldOffset(8)] // size = 4, padding = 4
        public CXIdxEntityLanguage lang;

        [FieldOffset(16)] // size = 8, padding = 0
        public CString name;

        [FieldOffset(24)] // size = 8, padding = 0
        public CString USR;

        [FieldOffset(32)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(64)] // size = 8, padding = 0
        public CXIdxAttrInfo** attributes;

        [FieldOffset(72)] // size = 4, padding = 4
        public uint numAttributes;
    }

    // Struct @ Index.h:6590:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
    public struct IndexerCallbacks
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public FnPtr_CXClientData_VoidPtr_Int abortQuery;

        [FieldOffset(8)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXDiagnosticSet_VoidPtr_Void diagnostic;

        [FieldOffset(16)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXFile_VoidPtr_CXIdxClientFile enteredMainFile;

        [FieldOffset(24)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXIdxIncludedFileInfoPtr_CXIdxClientFile ppIncludedFile;

        [FieldOffset(32)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXIdxImportedASTFileInfoPtr_CXIdxClientASTFile importedASTFile;

        [FieldOffset(40)] // size = 8, padding = 0
        public FnPtr_CXClientData_VoidPtr_CXIdxClientContainer startedTranslationUnit;

        [FieldOffset(48)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXIdxDeclInfoPtr_Void indexDeclaration;

        [FieldOffset(56)] // size = 8, padding = 0
        public FnPtr_CXClientData_CXIdxEntityRefInfoPtr_Void indexEntityReference;
    }

    // Struct @ Index.h:6239:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct CXIdxLoc
    {
        [FieldOffset(0)] // size = 16, padding = 0
        public fixed byte _ptr_data[16]; // void*[2]

        public Span<nint> ptr_data
        {
            get
            {
                fixed (CXIdxLoc* @this = &this)
                {
                    var pointer = &@this->_ptr_data[0];
                    var span = new Span<nint>(pointer, 2);
                    return span;
                }
            }
        }

        [FieldOffset(16)] // size = 4, padding = 4
        public uint int_data;
    }

    // Struct @ Index.h:1645:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct CXTUResourceUsageEntry
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public CXTUResourceUsageKind kind;

        [FieldOffset(8)] // size = 8, padding = 0
        public ulong amount;
    }

    // Struct @ Index.h:167:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct CXVersion
    {
        [FieldOffset(0)] // size = 4, padding = 0
        public int Major;

        [FieldOffset(4)] // size = 4, padding = 0
        public int Minor;

        [FieldOffset(8)] // size = 4, padding = 0
        public int Subminor;
    }

    // Struct @ Index.h:6428:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
    public struct CXIdxBaseClassInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxEntityInfo* @base;

        [FieldOffset(8)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(40)] // size = 24, padding = 0
        public CXIdxLoc loc;
    }

    // Struct @ Index.h:6434:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
    public struct CXIdxObjCProtocolRefInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXIdxEntityInfo* protocol;

        [FieldOffset(8)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(40)] // size = 24, padding = 0
        public CXIdxLoc loc;
    }

    // Struct @ Index.h:6538:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 96, Pack = 8)]
    public struct CXIdxEntityRefInfo
    {
        [FieldOffset(0)] // size = 4, padding = 4
        public CXIdxEntityRefKind kind;

        [FieldOffset(8)] // size = 32, padding = 0
        public CXCursor cursor;

        [FieldOffset(40)] // size = 24, padding = 0
        public CXIdxLoc loc;

        [FieldOffset(64)] // size = 8, padding = 0
        public CXIdxEntityInfo* referencedEntity;

        [FieldOffset(72)] // size = 8, padding = 0
        public CXIdxEntityInfo* parentEntity;

        [FieldOffset(80)] // size = 8, padding = 0
        public CXIdxContainerInfo* container;

        [FieldOffset(88)] // size = 4, padding = 4
        public CXSymbolRole role;
    }

    // Struct @ Index.h:6288:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 48, Pack = 8)]
    public struct CXIdxImportedASTFileInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXFile file;

        [FieldOffset(8)] // size = 8, padding = 0
        public CXModule module;

        [FieldOffset(16)] // size = 24, padding = 0
        public CXIdxLoc loc;

        [FieldOffset(40)] // size = 4, padding = 4
        public int isImplicit;
    }

    // Struct @ Index.h:6264:3 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 56, Pack = 8)]
    public struct CXIdxIncludedFileInfo
    {
        [FieldOffset(0)] // size = 24, padding = 0
        public CXIdxLoc hashLoc;

        [FieldOffset(24)] // size = 8, padding = 0
        public CString filename;

        [FieldOffset(32)] // size = 8, padding = 0
        public CXFile file;

        [FieldOffset(40)] // size = 4, padding = 0
        public int isImport;

        [FieldOffset(44)] // size = 4, padding = 0
        public int isAngled;

        [FieldOffset(48)] // size = 4, padding = 4
        public int isModuleImport;
    }

    // OpaqueType @ BuildSystem.h:39:16 (clang-c/BuildSystem.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXVirtualFileOverlayImpl
    {
    }

    // OpaqueType @ BuildSystem.h:100:16 (clang-c/BuildSystem.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXModuleMapDescriptorImpl
    {
    }

    // OpaqueType @ Index.h:86:16 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXTranslationUnitImpl
    {
    }

    // OpaqueType @ Index.h:81:16 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXTargetInfoImpl
    {
    }

    // OpaqueType @ Index.h:3046:16 (clang-c/Index.h)
    [StructLayout(LayoutKind.Sequential)]
    public struct CXCursorSetImpl
    {
    }

    // Typedef @ BuildSystem.h:39:42 (clang-c/BuildSystem.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXVirtualFileOverlay
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXVirtualFileOverlayImpl* Data;

        public static implicit operator CXVirtualFileOverlayImpl*(CXVirtualFileOverlay data) => data.Data;
        public static implicit operator CXVirtualFileOverlay(CXVirtualFileOverlayImpl* data) => new() { Data = data };
    }

    // Typedef @ BuildSystem.h:100:43 (clang-c/BuildSystem.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXModuleMapDescriptor
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXModuleMapDescriptorImpl* Data;

        public static implicit operator CXModuleMapDescriptorImpl*(CXModuleMapDescriptor data) => data.Data;
        public static implicit operator CXModuleMapDescriptor(CXModuleMapDescriptorImpl* data) => new() { Data = data };
    }

    // Typedef @ Index.h:75:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIndex
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIndex data) => data.Data;
        public static implicit operator CXIndex(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:353:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXFile
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXFile data) => data.Data;
        public static implicit operator CXFile(void* data) => new() { Data = data };
    }

    // Typedef @ _time_t.h:31:33 (/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS15.2.sdk/usr/include/sys/_types/_time_t.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct time_t
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public nint Data;

        public static implicit operator nint(time_t data) => data.Data;
        public static implicit operator time_t(nint data) => new() { Data = data };
    }

    // Typedef @ Index.h:86:39 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXTranslationUnit
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXTranslationUnitImpl* Data;

        public static implicit operator CXTranslationUnitImpl*(CXTranslationUnit data) => data.Data;
        public static implicit operator CXTranslationUnit(CXTranslationUnitImpl* data) => new() { Data = data };
    }

    // Typedef @ Index.h:780:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXDiagnosticSet
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXDiagnosticSet data) => data.Data;
        public static implicit operator CXDiagnosticSet(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:775:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXDiagnostic
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXDiagnostic data) => data.Data;
        public static implicit operator CXDiagnostic(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:81:34 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXTargetInfo
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXTargetInfoImpl* Data;

        public static implicit operator CXTargetInfoImpl*(CXTargetInfo data) => data.Data;
        public static implicit operator CXTargetInfo(CXTargetInfoImpl* data) => new() { Data = data };
    }

    // Typedef @ Index.h:3046:33 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXCursorSet
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public CXCursorSetImpl* Data;

        public static implicit operator CXCursorSetImpl*(CXCursorSet data) => data.Data;
        public static implicit operator CXCursorSet(CXCursorSetImpl* data) => new() { Data = data };
    }

    // Typedef @ Index.h:92:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXClientData
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXClientData data) => data.Data;
        public static implicit operator CXClientData(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:4383:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXPrintingPolicy
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXPrintingPolicy data) => data.Data;
        public static implicit operator CXPrintingPolicy(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:4730:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXModule
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXModule data) => data.Data;
        public static implicit operator CXModule(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:5175:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXCompletionString
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXCompletionString data) => data.Data;
        public static implicit operator CXCompletionString(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6010:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXEvalResult
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXEvalResult data) => data.Data;
        public static implicit operator CXEvalResult(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6081:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXRemapping
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXRemapping data) => data.Data;
        public static implicit operator CXRemapping(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6225:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIdxClientContainer
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIdxClientContainer data) => data.Data;
        public static implicit operator CXIdxClientContainer(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6219:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIdxClientEntity
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIdxClientEntity data) => data.Data;
        public static implicit operator CXIdxClientEntity(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6645:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIndexAction
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIndexAction data) => data.Data;
        public static implicit operator CXIndexAction(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6214:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIdxClientFile
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIdxClientFile data) => data.Data;
        public static implicit operator CXIdxClientFile(void* data) => new() { Data = data };
    }

    // Typedef @ Index.h:6231:15 (clang-c/Index.h)
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct CXIdxClientASTFile
    {
        [FieldOffset(0)] // size = 8, padding = 0
        public void* Data;

        public static implicit operator void*(CXIdxClientASTFile data) => data.Data;
        public static implicit operator CXIdxClientASTFile(void* data) => new() { Data = data };
    }

    // Enum @ CXErrorCode.h:28:6 (clang-c/CXErrorCode.h)
    public enum CXErrorCode : int
    {
        CXError_Success = 0,
        CXError_Failure = 1,
        CXError_Crashed = 2,
        CXError_InvalidArguments = 3,
        CXError_ASTReadError = 4
    }

    // Enum @ Index.h:125:6 (clang-c/Index.h)
    public enum CXAvailabilityKind : int
    {
        CXAvailability_Available = 0,
        CXAvailability_Deprecated = 1,
        CXAvailability_NotAvailable = 2,
        CXAvailability_NotAccessible = 3
    }

    // Enum @ Index.h:174:6 (clang-c/Index.h)
    public enum CXCursor_ExceptionSpecificationKind : int
    {
        CXCursor_ExceptionSpecificationKind_None = 0,
        CXCursor_ExceptionSpecificationKind_DynamicNone = 1,
        CXCursor_ExceptionSpecificationKind_Dynamic = 2,
        CXCursor_ExceptionSpecificationKind_MSAny = 3,
        CXCursor_ExceptionSpecificationKind_BasicNoexcept = 4,
        CXCursor_ExceptionSpecificationKind_ComputedNoexcept = 5,
        CXCursor_ExceptionSpecificationKind_Unevaluated = 6,
        CXCursor_ExceptionSpecificationKind_Uninstantiated = 7,
        CXCursor_ExceptionSpecificationKind_Unparsed = 8,
        CXCursor_ExceptionSpecificationKind_NoThrow = 9
    }

    // Enum @ Index.h:277:9 (clang-c/Index.h)
    public enum CXGlobalOptFlags : int
    {
        CXGlobalOpt_None = 0,
        CXGlobalOpt_ThreadBackgroundPriorityForIndexing = 1,
        CXGlobalOpt_ThreadBackgroundPriorityForEditing = 2,
        CXGlobalOpt_ThreadBackgroundPriorityForAll = 3
    }

    // Enum @ Index.h:739:6 (clang-c/Index.h)
    public enum CXDiagnosticSeverity : int
    {
        CXDiagnostic_Ignored = 0,
        CXDiagnostic_Note = 1,
        CXDiagnostic_Warning = 2,
        CXDiagnostic_Error = 3,
        CXDiagnostic_Fatal = 4
    }

    // Enum @ Index.h:803:6 (clang-c/Index.h)
    public enum CXLoadDiag_Error : int
    {
        CXLoadDiag_None = 0,
        CXLoadDiag_Unknown = 1,
        CXLoadDiag_CannotLoad = 2,
        CXLoadDiag_InvalidFile = 3
    }

    // Enum @ Index.h:895:6 (clang-c/Index.h)
    public enum CXDiagnosticDisplayOptions : int
    {
        CXDiagnostic_DisplaySourceLocation = 1,
        CXDiagnostic_DisplayColumn = 2,
        CXDiagnostic_DisplaySourceRanges = 4,
        CXDiagnostic_DisplayOption = 8,
        CXDiagnostic_DisplayCategoryId = 16,
        CXDiagnostic_DisplayCategoryName = 32
    }

    // Enum @ Index.h:1199:6 (clang-c/Index.h)
    public enum CXTranslationUnit_Flags : int
    {
        CXTranslationUnit_None = 0,
        CXTranslationUnit_DetailedPreprocessingRecord = 1,
        CXTranslationUnit_Incomplete = 2,
        CXTranslationUnit_PrecompiledPreamble = 4,
        CXTranslationUnit_CacheCompletionResults = 8,
        CXTranslationUnit_ForSerialization = 16,
        CXTranslationUnit_CXXChainedPCH = 32,
        CXTranslationUnit_SkipFunctionBodies = 64,
        CXTranslationUnit_IncludeBriefCommentsInCodeCompletion = 128,
        CXTranslationUnit_CreatePreambleOnFirstParse = 256,
        CXTranslationUnit_KeepGoing = 512,
        CXTranslationUnit_SingleFileParse = 1024,
        CXTranslationUnit_LimitSkipFunctionBodiesToPreamble = 2048,
        CXTranslationUnit_IncludeAttributedTypes = 4096,
        CXTranslationUnit_VisitImplicitAttributes = 8192,
        CXTranslationUnit_IgnoreNonErrorsFromIncludedFiles = 16384,
        CXTranslationUnit_RetainExcludedConditionalBlocks = 32768
    }

    // Enum @ Index.h:1442:6 (clang-c/Index.h)
    public enum CXSaveTranslationUnit_Flags : int
    {
        CXSaveTranslationUnit_None = 0
    }

    // Enum @ Index.h:1464:6 (clang-c/Index.h)
    public enum CXSaveError : int
    {
        CXSaveError_None = 0,
        CXSaveError_Unknown = 1,
        CXSaveError_TranslationErrors = 2,
        CXSaveError_InvalidTU = 3
    }

    // Enum @ Index.h:1543:6 (clang-c/Index.h)
    public enum CXReparse_Flags : int
    {
        CXReparse_None = 0
    }

    // Enum @ Index.h:1609:6 (clang-c/Index.h)
    public enum CXTUResourceUsageKind : int
    {
        CXTUResourceUsage_AST = 1,
        CXTUResourceUsage_Identifiers = 2,
        CXTUResourceUsage_Selectors = 3,
        CXTUResourceUsage_GlobalCompletionResults = 4,
        CXTUResourceUsage_SourceManagerContentCache = 5,
        CXTUResourceUsage_AST_SideTables = 6,
        CXTUResourceUsage_SourceManager_Membuffer_Malloc = 7,
        CXTUResourceUsage_SourceManager_Membuffer_MMap = 8,
        CXTUResourceUsage_ExternalASTSource_Membuffer_Malloc = 9,
        CXTUResourceUsage_ExternalASTSource_Membuffer_MMap = 10,
        CXTUResourceUsage_Preprocessor = 11,
        CXTUResourceUsage_PreprocessingRecord = 12,
        CXTUResourceUsage_SourceManager_DataStructures = 13,
        CXTUResourceUsage_Preprocessor_HeaderSearch = 14,
        CXTUResourceUsage_MEMORY_IN_BYTES_BEGIN = 1,
        CXTUResourceUsage_MEMORY_IN_BYTES_END = 14,
        CXTUResourceUsage_First = 1,
        CXTUResourceUsage_Last = 14
    }

    // Enum @ Index.h:1706:6 (clang-c/Index.h)
    public enum CXCursorKind : int
    {
        CXCursor_UnexposedDecl = 1,
        CXCursor_StructDecl = 2,
        CXCursor_UnionDecl = 3,
        CXCursor_ClassDecl = 4,
        CXCursor_EnumDecl = 5,
        CXCursor_FieldDecl = 6,
        CXCursor_EnumConstantDecl = 7,
        CXCursor_FunctionDecl = 8,
        CXCursor_VarDecl = 9,
        CXCursor_ParmDecl = 10,
        CXCursor_ObjCInterfaceDecl = 11,
        CXCursor_ObjCCategoryDecl = 12,
        CXCursor_ObjCProtocolDecl = 13,
        CXCursor_ObjCPropertyDecl = 14,
        CXCursor_ObjCIvarDecl = 15,
        CXCursor_ObjCInstanceMethodDecl = 16,
        CXCursor_ObjCClassMethodDecl = 17,
        CXCursor_ObjCImplementationDecl = 18,
        CXCursor_ObjCCategoryImplDecl = 19,
        CXCursor_TypedefDecl = 20,
        CXCursor_CXXMethod = 21,
        CXCursor_Namespace = 22,
        CXCursor_LinkageSpec = 23,
        CXCursor_Constructor = 24,
        CXCursor_Destructor = 25,
        CXCursor_ConversionFunction = 26,
        CXCursor_TemplateTypeParameter = 27,
        CXCursor_NonTypeTemplateParameter = 28,
        CXCursor_TemplateTemplateParameter = 29,
        CXCursor_FunctionTemplate = 30,
        CXCursor_ClassTemplate = 31,
        CXCursor_ClassTemplatePartialSpecialization = 32,
        CXCursor_NamespaceAlias = 33,
        CXCursor_UsingDirective = 34,
        CXCursor_UsingDeclaration = 35,
        CXCursor_TypeAliasDecl = 36,
        CXCursor_ObjCSynthesizeDecl = 37,
        CXCursor_ObjCDynamicDecl = 38,
        CXCursor_CXXAccessSpecifier = 39,
        CXCursor_FirstDecl = CXCursor_UnexposedDecl,
        CXCursor_LastDecl = CXCursor_CXXAccessSpecifier,
        CXCursor_FirstRef = 40,
        CXCursor_ObjCSuperClassRef = 40,
        CXCursor_ObjCProtocolRef = 41,
        CXCursor_ObjCClassRef = 42,
        CXCursor_TypeRef = 43,
        CXCursor_CXXBaseSpecifier = 44,
        CXCursor_TemplateRef = 45,
        CXCursor_NamespaceRef = 46,
        CXCursor_MemberRef = 47,
        CXCursor_LabelRef = 48,
        CXCursor_OverloadedDeclRef = 49,
        CXCursor_VariableRef = 50,
        CXCursor_LastRef = CXCursor_VariableRef,
        CXCursor_FirstInvalid = 70,
        CXCursor_InvalidFile = 70,
        CXCursor_NoDeclFound = 71,
        CXCursor_NotImplemented = 72,
        CXCursor_InvalidCode = 73,
        CXCursor_LastInvalid = CXCursor_InvalidCode,
        CXCursor_FirstExpr = 100,
        CXCursor_UnexposedExpr = 100,
        CXCursor_DeclRefExpr = 101,
        CXCursor_MemberRefExpr = 102,
        CXCursor_CallExpr = 103,
        CXCursor_ObjCMessageExpr = 104,
        CXCursor_BlockExpr = 105,
        CXCursor_IntegerLiteral = 106,
        CXCursor_FloatingLiteral = 107,
        CXCursor_ImaginaryLiteral = 108,
        CXCursor_StringLiteral = 109,
        CXCursor_CharacterLiteral = 110,
        CXCursor_ParenExpr = 111,
        CXCursor_UnaryOperator = 112,
        CXCursor_ArraySubscriptExpr = 113,
        CXCursor_BinaryOperator = 114,
        CXCursor_CompoundAssignOperator = 115,
        CXCursor_ConditionalOperator = 116,
        CXCursor_CStyleCastExpr = 117,
        CXCursor_CompoundLiteralExpr = 118,
        CXCursor_InitListExpr = 119,
        CXCursor_AddrLabelExpr = 120,
        CXCursor_StmtExpr = 121,
        CXCursor_GenericSelectionExpr = 122,
        CXCursor_GNUNullExpr = 123,
        CXCursor_CXXStaticCastExpr = 124,
        CXCursor_CXXDynamicCastExpr = 125,
        CXCursor_CXXReinterpretCastExpr = 126,
        CXCursor_CXXConstCastExpr = 127,
        CXCursor_CXXFunctionalCastExpr = 128,
        CXCursor_CXXTypeidExpr = 129,
        CXCursor_CXXBoolLiteralExpr = 130,
        CXCursor_CXXNullPtrLiteralExpr = 131,
        CXCursor_CXXThisExpr = 132,
        CXCursor_CXXThrowExpr = 133,
        CXCursor_CXXNewExpr = 134,
        CXCursor_CXXDeleteExpr = 135,
        CXCursor_UnaryExpr = 136,
        CXCursor_ObjCStringLiteral = 137,
        CXCursor_ObjCEncodeExpr = 138,
        CXCursor_ObjCSelectorExpr = 139,
        CXCursor_ObjCProtocolExpr = 140,
        CXCursor_ObjCBridgedCastExpr = 141,
        CXCursor_PackExpansionExpr = 142,
        CXCursor_SizeOfPackExpr = 143,
        CXCursor_LambdaExpr = 144,
        CXCursor_ObjCBoolLiteralExpr = 145,
        CXCursor_ObjCSelfExpr = 146,
        CXCursor_OMPArraySectionExpr = 147,
        CXCursor_ObjCAvailabilityCheckExpr = 148,
        CXCursor_FixedPointLiteral = 149,
        CXCursor_OMPArrayShapingExpr = 150,
        CXCursor_OMPIteratorExpr = 151,
        CXCursor_CXXAddrspaceCastExpr = 152,
        CXCursor_LastExpr = CXCursor_CXXAddrspaceCastExpr,
        CXCursor_FirstStmt = 200,
        CXCursor_UnexposedStmt = 200,
        CXCursor_LabelStmt = 201,
        CXCursor_CompoundStmt = 202,
        CXCursor_CaseStmt = 203,
        CXCursor_DefaultStmt = 204,
        CXCursor_IfStmt = 205,
        CXCursor_SwitchStmt = 206,
        CXCursor_WhileStmt = 207,
        CXCursor_DoStmt = 208,
        CXCursor_ForStmt = 209,
        CXCursor_GotoStmt = 210,
        CXCursor_IndirectGotoStmt = 211,
        CXCursor_ContinueStmt = 212,
        CXCursor_BreakStmt = 213,
        CXCursor_ReturnStmt = 214,
        CXCursor_GCCAsmStmt = 215,
        CXCursor_AsmStmt = CXCursor_GCCAsmStmt,
        CXCursor_ObjCAtTryStmt = 216,
        CXCursor_ObjCAtCatchStmt = 217,
        CXCursor_ObjCAtFinallyStmt = 218,
        CXCursor_ObjCAtThrowStmt = 219,
        CXCursor_ObjCAtSynchronizedStmt = 220,
        CXCursor_ObjCAutoreleasePoolStmt = 221,
        CXCursor_ObjCForCollectionStmt = 222,
        CXCursor_CXXCatchStmt = 223,
        CXCursor_CXXTryStmt = 224,
        CXCursor_CXXForRangeStmt = 225,
        CXCursor_SEHTryStmt = 226,
        CXCursor_SEHExceptStmt = 227,
        CXCursor_SEHFinallyStmt = 228,
        CXCursor_MSAsmStmt = 229,
        CXCursor_NullStmt = 230,
        CXCursor_DeclStmt = 231,
        CXCursor_OMPParallelDirective = 232,
        CXCursor_OMPSimdDirective = 233,
        CXCursor_OMPForDirective = 234,
        CXCursor_OMPSectionsDirective = 235,
        CXCursor_OMPSectionDirective = 236,
        CXCursor_OMPSingleDirective = 237,
        CXCursor_OMPParallelForDirective = 238,
        CXCursor_OMPParallelSectionsDirective = 239,
        CXCursor_OMPTaskDirective = 240,
        CXCursor_OMPMasterDirective = 241,
        CXCursor_OMPCriticalDirective = 242,
        CXCursor_OMPTaskyieldDirective = 243,
        CXCursor_OMPBarrierDirective = 244,
        CXCursor_OMPTaskwaitDirective = 245,
        CXCursor_OMPFlushDirective = 246,
        CXCursor_SEHLeaveStmt = 247,
        CXCursor_OMPOrderedDirective = 248,
        CXCursor_OMPAtomicDirective = 249,
        CXCursor_OMPForSimdDirective = 250,
        CXCursor_OMPParallelForSimdDirective = 251,
        CXCursor_OMPTargetDirective = 252,
        CXCursor_OMPTeamsDirective = 253,
        CXCursor_OMPTaskgroupDirective = 254,
        CXCursor_OMPCancellationPointDirective = 255,
        CXCursor_OMPCancelDirective = 256,
        CXCursor_OMPTargetDataDirective = 257,
        CXCursor_OMPTaskLoopDirective = 258,
        CXCursor_OMPTaskLoopSimdDirective = 259,
        CXCursor_OMPDistributeDirective = 260,
        CXCursor_OMPTargetEnterDataDirective = 261,
        CXCursor_OMPTargetExitDataDirective = 262,
        CXCursor_OMPTargetParallelDirective = 263,
        CXCursor_OMPTargetParallelForDirective = 264,
        CXCursor_OMPTargetUpdateDirective = 265,
        CXCursor_OMPDistributeParallelForDirective = 266,
        CXCursor_OMPDistributeParallelForSimdDirective = 267,
        CXCursor_OMPDistributeSimdDirective = 268,
        CXCursor_OMPTargetParallelForSimdDirective = 269,
        CXCursor_OMPTargetSimdDirective = 270,
        CXCursor_OMPTeamsDistributeDirective = 271,
        CXCursor_OMPTeamsDistributeSimdDirective = 272,
        CXCursor_OMPTeamsDistributeParallelForSimdDirective = 273,
        CXCursor_OMPTeamsDistributeParallelForDirective = 274,
        CXCursor_OMPTargetTeamsDirective = 275,
        CXCursor_OMPTargetTeamsDistributeDirective = 276,
        CXCursor_OMPTargetTeamsDistributeParallelForDirective = 277,
        CXCursor_OMPTargetTeamsDistributeParallelForSimdDirective = 278,
        CXCursor_OMPTargetTeamsDistributeSimdDirective = 279,
        CXCursor_BuiltinBitCastExpr = 280,
        CXCursor_OMPMasterTaskLoopDirective = 281,
        CXCursor_OMPParallelMasterTaskLoopDirective = 282,
        CXCursor_OMPMasterTaskLoopSimdDirective = 283,
        CXCursor_OMPParallelMasterTaskLoopSimdDirective = 284,
        CXCursor_OMPParallelMasterDirective = 285,
        CXCursor_OMPDepobjDirective = 286,
        CXCursor_OMPScanDirective = 287,
        CXCursor_OMPTileDirective = 288,
        CXCursor_OMPCanonicalLoop = 289,
        CXCursor_OMPInteropDirective = 290,
        CXCursor_OMPDispatchDirective = 291,
        CXCursor_OMPMaskedDirective = 292,
        CXCursor_OMPUnrollDirective = 293,
        CXCursor_OMPMetaDirective = 294,
        CXCursor_OMPGenericLoopDirective = 295,
        CXCursor_LastStmt = CXCursor_OMPGenericLoopDirective,
        CXCursor_TranslationUnit = 300,
        CXCursor_FirstAttr = 400,
        CXCursor_UnexposedAttr = 400,
        CXCursor_IBActionAttr = 401,
        CXCursor_IBOutletAttr = 402,
        CXCursor_IBOutletCollectionAttr = 403,
        CXCursor_CXXFinalAttr = 404,
        CXCursor_CXXOverrideAttr = 405,
        CXCursor_AnnotateAttr = 406,
        CXCursor_AsmLabelAttr = 407,
        CXCursor_PackedAttr = 408,
        CXCursor_PureAttr = 409,
        CXCursor_ConstAttr = 410,
        CXCursor_NoDuplicateAttr = 411,
        CXCursor_CUDAConstantAttr = 412,
        CXCursor_CUDADeviceAttr = 413,
        CXCursor_CUDAGlobalAttr = 414,
        CXCursor_CUDAHostAttr = 415,
        CXCursor_CUDASharedAttr = 416,
        CXCursor_VisibilityAttr = 417,
        CXCursor_DLLExport = 418,
        CXCursor_DLLImport = 419,
        CXCursor_NSReturnsRetained = 420,
        CXCursor_NSReturnsNotRetained = 421,
        CXCursor_NSReturnsAutoreleased = 422,
        CXCursor_NSConsumesSelf = 423,
        CXCursor_NSConsumed = 424,
        CXCursor_ObjCException = 425,
        CXCursor_ObjCNSObject = 426,
        CXCursor_ObjCIndependentClass = 427,
        CXCursor_ObjCPreciseLifetime = 428,
        CXCursor_ObjCReturnsInnerPointer = 429,
        CXCursor_ObjCRequiresSuper = 430,
        CXCursor_ObjCRootClass = 431,
        CXCursor_ObjCSubclassingRestricted = 432,
        CXCursor_ObjCExplicitProtocolImpl = 433,
        CXCursor_ObjCDesignatedInitializer = 434,
        CXCursor_ObjCRuntimeVisible = 435,
        CXCursor_ObjCBoxable = 436,
        CXCursor_FlagEnum = 437,
        CXCursor_ConvergentAttr = 438,
        CXCursor_WarnUnusedAttr = 439,
        CXCursor_WarnUnusedResultAttr = 440,
        CXCursor_AlignedAttr = 441,
        CXCursor_LastAttr = CXCursor_AlignedAttr,
        CXCursor_PreprocessingDirective = 500,
        CXCursor_MacroDefinition = 501,
        CXCursor_MacroExpansion = 502,
        CXCursor_MacroInstantiation = CXCursor_MacroExpansion,
        CXCursor_InclusionDirective = 503,
        CXCursor_FirstPreprocessing = CXCursor_PreprocessingDirective,
        CXCursor_LastPreprocessing = CXCursor_InclusionDirective,
        CXCursor_ModuleImportDecl = 600,
        CXCursor_TypeAliasTemplateDecl = 601,
        CXCursor_StaticAssert = 602,
        CXCursor_FriendDecl = 603,
        CXCursor_FirstExtraDecl = CXCursor_ModuleImportDecl,
        CXCursor_LastExtraDecl = CXCursor_FriendDecl,
        CXCursor_OverloadCandidate = 700
    }

    // Enum @ Index.h:2847:6 (clang-c/Index.h)
    public enum CXLinkageKind : int
    {
        CXLinkage_Invalid = 0,
        CXLinkage_NoLinkage = 1,
        CXLinkage_Internal = 2,
        CXLinkage_UniqueExternal = 3,
        CXLinkage_External = 4
    }

    // Enum @ Index.h:2870:6 (clang-c/Index.h)
    public enum CXVisibilityKind : int
    {
        CXVisibility_Invalid = 0,
        CXVisibility_Hidden = 1,
        CXVisibility_Protected = 2,
        CXVisibility_Default = 3
    }

    // Enum @ Index.h:3014:6 (clang-c/Index.h)
    public enum CXLanguageKind : int
    {
        CXLanguage_Invalid = 0,
        CXLanguage_C = 1,
        CXLanguage_ObjC = 2,
        CXLanguage_CPlusPlus = 3
    }

    // Enum @ Index.h:3030:6 (clang-c/Index.h)
    public enum CXTLSKind : int
    {
        CXTLS_None = 0,
        CXTLS_Dynamic = 1,
        CXTLS_Static = 2
    }

    // Enum @ Index.h:3274:6 (clang-c/Index.h)
    public enum CXTypeKind : int
    {
        CXType_Invalid = 0,
        CXType_Unexposed = 1,
        CXType_Void = 2,
        CXType_Bool = 3,
        CXType_Char_U = 4,
        CXType_UChar = 5,
        CXType_Char16 = 6,
        CXType_Char32 = 7,
        CXType_UShort = 8,
        CXType_UInt = 9,
        CXType_ULong = 10,
        CXType_ULongLong = 11,
        CXType_UInt128 = 12,
        CXType_Char_S = 13,
        CXType_SChar = 14,
        CXType_WChar = 15,
        CXType_Short = 16,
        CXType_Int = 17,
        CXType_Long = 18,
        CXType_LongLong = 19,
        CXType_Int128 = 20,
        CXType_Float = 21,
        CXType_Double = 22,
        CXType_LongDouble = 23,
        CXType_NullPtr = 24,
        CXType_Overload = 25,
        CXType_Dependent = 26,
        CXType_ObjCId = 27,
        CXType_ObjCClass = 28,
        CXType_ObjCSel = 29,
        CXType_Float128 = 30,
        CXType_Half = 31,
        CXType_Float16 = 32,
        CXType_ShortAccum = 33,
        CXType_Accum = 34,
        CXType_LongAccum = 35,
        CXType_UShortAccum = 36,
        CXType_UAccum = 37,
        CXType_ULongAccum = 38,
        CXType_BFloat16 = 39,
        CXType_Ibm128 = 40,
        CXType_FirstBuiltin = 2,
        CXType_LastBuiltin = 40,
        CXType_Complex = 100,
        CXType_Pointer = 101,
        CXType_BlockPointer = 102,
        CXType_LValueReference = 103,
        CXType_RValueReference = 104,
        CXType_Record = 105,
        CXType_Enum = 106,
        CXType_Typedef = 107,
        CXType_ObjCInterface = 108,
        CXType_ObjCObjectPointer = 109,
        CXType_FunctionNoProto = 110,
        CXType_FunctionProto = 111,
        CXType_ConstantArray = 112,
        CXType_Vector = 113,
        CXType_IncompleteArray = 114,
        CXType_VariableArray = 115,
        CXType_DependentSizedArray = 116,
        CXType_MemberPointer = 117,
        CXType_Auto = 118,
        CXType_Elaborated = 119,
        CXType_Pipe = 120,
        CXType_OCLImage1dRO = 121,
        CXType_OCLImage1dArrayRO = 122,
        CXType_OCLImage1dBufferRO = 123,
        CXType_OCLImage2dRO = 124,
        CXType_OCLImage2dArrayRO = 125,
        CXType_OCLImage2dDepthRO = 126,
        CXType_OCLImage2dArrayDepthRO = 127,
        CXType_OCLImage2dMSAARO = 128,
        CXType_OCLImage2dArrayMSAARO = 129,
        CXType_OCLImage2dMSAADepthRO = 130,
        CXType_OCLImage2dArrayMSAADepthRO = 131,
        CXType_OCLImage3dRO = 132,
        CXType_OCLImage1dWO = 133,
        CXType_OCLImage1dArrayWO = 134,
        CXType_OCLImage1dBufferWO = 135,
        CXType_OCLImage2dWO = 136,
        CXType_OCLImage2dArrayWO = 137,
        CXType_OCLImage2dDepthWO = 138,
        CXType_OCLImage2dArrayDepthWO = 139,
        CXType_OCLImage2dMSAAWO = 140,
        CXType_OCLImage2dArrayMSAAWO = 141,
        CXType_OCLImage2dMSAADepthWO = 142,
        CXType_OCLImage2dArrayMSAADepthWO = 143,
        CXType_OCLImage3dWO = 144,
        CXType_OCLImage1dRW = 145,
        CXType_OCLImage1dArrayRW = 146,
        CXType_OCLImage1dBufferRW = 147,
        CXType_OCLImage2dRW = 148,
        CXType_OCLImage2dArrayRW = 149,
        CXType_OCLImage2dDepthRW = 150,
        CXType_OCLImage2dArrayDepthRW = 151,
        CXType_OCLImage2dMSAARW = 152,
        CXType_OCLImage2dArrayMSAARW = 153,
        CXType_OCLImage2dMSAADepthRW = 154,
        CXType_OCLImage2dArrayMSAADepthRW = 155,
        CXType_OCLImage3dRW = 156,
        CXType_OCLSampler = 157,
        CXType_OCLEvent = 158,
        CXType_OCLQueue = 159,
        CXType_OCLReserveID = 160,
        CXType_ObjCObject = 161,
        CXType_ObjCTypeParam = 162,
        CXType_Attributed = 163,
        CXType_OCLIntelSubgroupAVCMcePayload = 164,
        CXType_OCLIntelSubgroupAVCImePayload = 165,
        CXType_OCLIntelSubgroupAVCRefPayload = 166,
        CXType_OCLIntelSubgroupAVCSicPayload = 167,
        CXType_OCLIntelSubgroupAVCMceResult = 168,
        CXType_OCLIntelSubgroupAVCImeResult = 169,
        CXType_OCLIntelSubgroupAVCRefResult = 170,
        CXType_OCLIntelSubgroupAVCSicResult = 171,
        CXType_OCLIntelSubgroupAVCImeResultSingleRefStreamout = 172,
        CXType_OCLIntelSubgroupAVCImeResultDualRefStreamout = 173,
        CXType_OCLIntelSubgroupAVCImeSingleRefStreamin = 174,
        CXType_OCLIntelSubgroupAVCImeDualRefStreamin = 175,
        CXType_ExtVector = 176,
        CXType_Atomic = 177,
        CXType_BTFTagAttributed = 178
    }

    // Enum @ Index.h:3427:6 (clang-c/Index.h)
    public enum CXCallingConv : int
    {
        CXCallingConv_Default = 0,
        CXCallingConv_C = 1,
        CXCallingConv_X86StdCall = 2,
        CXCallingConv_X86FastCall = 3,
        CXCallingConv_X86ThisCall = 4,
        CXCallingConv_X86Pascal = 5,
        CXCallingConv_AAPCS = 6,
        CXCallingConv_AAPCS_VFP = 7,
        CXCallingConv_X86RegCall = 8,
        CXCallingConv_IntelOclBicc = 9,
        CXCallingConv_Win64 = 10,
        CXCallingConv_X86_64Win64 = 10,
        CXCallingConv_X86_64SysV = 11,
        CXCallingConv_X86VectorCall = 12,
        CXCallingConv_Swift = 13,
        CXCallingConv_PreserveMost = 14,
        CXCallingConv_PreserveAll = 15,
        CXCallingConv_AArch64VectorCall = 16,
        CXCallingConv_SwiftAsync = 17,
        CXCallingConv_Invalid = 100,
        CXCallingConv_Unexposed = 200
    }

    // Enum @ Index.h:3543:6 (clang-c/Index.h)
    public enum CXTemplateArgumentKind : int
    {
        CXTemplateArgumentKind_Null = 0,
        CXTemplateArgumentKind_Type = 1,
        CXTemplateArgumentKind_Declaration = 2,
        CXTemplateArgumentKind_NullPtr = 3,
        CXTemplateArgumentKind_Integral = 4,
        CXTemplateArgumentKind_Template = 5,
        CXTemplateArgumentKind_TemplateExpansion = 6,
        CXTemplateArgumentKind_Expression = 7,
        CXTemplateArgumentKind_Pack = 8,
        CXTemplateArgumentKind_Invalid = 9
    }

    // Enum @ Index.h:3896:6 (clang-c/Index.h)
    public enum CXTypeNullabilityKind : int
    {
        CXTypeNullability_NonNull = 0,
        CXTypeNullability_Nullable = 1,
        CXTypeNullability_Unspecified = 2,
        CXTypeNullability_Invalid = 3,
        CXTypeNullability_NullableResult = 4
    }

    // Enum @ Index.h:3939:6 (clang-c/Index.h)
    public enum CXTypeLayoutError : int
    {
        CXTypeLayoutError_Invalid = -1,
        CXTypeLayoutError_Incomplete = -2,
        CXTypeLayoutError_Dependent = -3,
        CXTypeLayoutError_NotConstantSize = -4,
        CXTypeLayoutError_InvalidFieldName = -5,
        CXTypeLayoutError_Undeduced = -6
    }

    // Enum @ Index.h:4060:6 (clang-c/Index.h)
    public enum CXRefQualifierKind : int
    {
        CXRefQualifier_None = 0,
        CXRefQualifier_LValue = 1,
        CXRefQualifier_RValue = 2
    }

    // Enum @ Index.h:4109:6 (clang-c/Index.h)
    public enum CX_CXXAccessSpecifier : int
    {
        CX_CXXInvalidAccessSpecifier = 0,
        CX_CXXPublic = 1,
        CX_CXXProtected = 2,
        CX_CXXPrivate = 3
    }

    // Enum @ Index.h:4129:6 (clang-c/Index.h)
    public enum CX_StorageClass : int
    {
        CX_SC_Invalid = 0,
        CX_SC_None = 1,
        CX_SC_Extern = 2,
        CX_SC_Static = 3,
        CX_SC_PrivateExtern = 4,
        CX_SC_OpenCLWorkGroupLocal = 5,
        CX_SC_Auto = 6,
        CX_SC_Register = 7
    }

    // Enum @ Index.h:4213:6 (clang-c/Index.h)
    public enum CXChildVisitResult : int
    {
        CXChildVisit_Break = 0,
        CXChildVisit_Continue = 1,
        CXChildVisit_Recurse = 2
    }

    // Enum @ Index.h:4390:6 (clang-c/Index.h)
    public enum CXPrintingPolicyProperty : int
    {
        CXPrintingPolicy_Indentation = 0,
        CXPrintingPolicy_SuppressSpecifiers = 1,
        CXPrintingPolicy_SuppressTagKeyword = 2,
        CXPrintingPolicy_IncludeTagDefinition = 3,
        CXPrintingPolicy_SuppressScope = 4,
        CXPrintingPolicy_SuppressUnwrittenScope = 5,
        CXPrintingPolicy_SuppressInitializers = 6,
        CXPrintingPolicy_ConstantArraySizeAsWritten = 7,
        CXPrintingPolicy_AnonymousTagLocations = 8,
        CXPrintingPolicy_SuppressStrongLifetime = 9,
        CXPrintingPolicy_SuppressLifetimeQualifiers = 10,
        CXPrintingPolicy_SuppressTemplateArgsInCXXConstructors = 11,
        CXPrintingPolicy_Bool = 12,
        CXPrintingPolicy_Restrict = 13,
        CXPrintingPolicy_Alignof = 14,
        CXPrintingPolicy_UnderscoreAlignof = 15,
        CXPrintingPolicy_UseVoidForZeroParams = 16,
        CXPrintingPolicy_TerseOutput = 17,
        CXPrintingPolicy_PolishForDeclaration = 18,
        CXPrintingPolicy_Half = 19,
        CXPrintingPolicy_MSWChar = 20,
        CXPrintingPolicy_IncludeNewlines = 21,
        CXPrintingPolicy_MSVCFormatting = 22,
        CXPrintingPolicy_ConstantsAsWritten = 23,
        CXPrintingPolicy_SuppressImplicitBase = 24,
        CXPrintingPolicy_FullyQualifiedName = 25,
        CXPrintingPolicy_LastProperty = 25
    }

    // Enum @ Index.h:4581:9 (clang-c/Index.h)
    public enum CXObjCPropertyAttrKind : int
    {
        CXObjCPropertyAttr_noattr = 0,
        CXObjCPropertyAttr_readonly = 1,
        CXObjCPropertyAttr_getter = 2,
        CXObjCPropertyAttr_assign = 4,
        CXObjCPropertyAttr_readwrite = 8,
        CXObjCPropertyAttr_retain = 16,
        CXObjCPropertyAttr_copy = 32,
        CXObjCPropertyAttr_nonatomic = 64,
        CXObjCPropertyAttr_setter = 128,
        CXObjCPropertyAttr_atomic = 256,
        CXObjCPropertyAttr_weak = 512,
        CXObjCPropertyAttr_strong = 1024,
        CXObjCPropertyAttr_unsafe_unretained = 2048,
        CXObjCPropertyAttr_class = 4096
    }

    // Enum @ Index.h:4624:9 (clang-c/Index.h)
    public enum CXObjCDeclQualifierKind : int
    {
        CXObjCDeclQualifier_None = 0,
        CXObjCDeclQualifier_In = 1,
        CXObjCDeclQualifier_Inout = 2,
        CXObjCDeclQualifier_Out = 4,
        CXObjCDeclQualifier_Bycopy = 8,
        CXObjCDeclQualifier_Byref = 16,
        CXObjCDeclQualifier_Oneway = 32
    }

    // Enum @ Index.h:4949:6 (clang-c/Index.h)
    public enum CXNameRefFlags : int
    {
        CXNameRange_WantQualifier = 1,
        CXNameRange_WantTemplateArgs = 2,
        CXNameRange_WantSinglePiece = 4
    }

    // Enum @ Index.h:4992:14 (clang-c/Index.h)
    public enum CXTokenKind : int
    {
        CXToken_Punctuation = 0,
        CXToken_Keyword = 1,
        CXToken_Identifier = 2,
        CXToken_Literal = 3,
        CXToken_Comment = 4
    }

    // Enum @ Index.h:5207:6 (clang-c/Index.h)
    public enum CXCompletionChunkKind : int
    {
        CXCompletionChunk_Optional = 0,
        CXCompletionChunk_TypedText = 1,
        CXCompletionChunk_Text = 2,
        CXCompletionChunk_Placeholder = 3,
        CXCompletionChunk_Informative = 4,
        CXCompletionChunk_CurrentParameter = 5,
        CXCompletionChunk_LeftParen = 6,
        CXCompletionChunk_RightParen = 7,
        CXCompletionChunk_LeftBracket = 8,
        CXCompletionChunk_RightBracket = 9,
        CXCompletionChunk_LeftBrace = 10,
        CXCompletionChunk_RightBrace = 11,
        CXCompletionChunk_LeftAngle = 12,
        CXCompletionChunk_RightAngle = 13,
        CXCompletionChunk_Comma = 14,
        CXCompletionChunk_ResultType = 15,
        CXCompletionChunk_Colon = 16,
        CXCompletionChunk_SemiColon = 17,
        CXCompletionChunk_Equal = 18,
        CXCompletionChunk_HorizontalSpace = 19,
        CXCompletionChunk_VerticalSpace = 20
    }

    // Enum @ Index.h:5598:6 (clang-c/Index.h)
    public enum CXCodeComplete_Flags : int
    {
        CXCodeComplete_IncludeMacros = 1,
        CXCodeComplete_IncludeCodePatterns = 2,
        CXCodeComplete_IncludeBriefComments = 4,
        CXCodeComplete_SkipPreamble = 8,
        CXCodeComplete_IncludeCompletionsWithFixIts = 16
    }

    // Enum @ Index.h:5637:6 (clang-c/Index.h)
    public enum CXCompletionContext : int
    {
        CXCompletionContext_Unexposed = 0,
        CXCompletionContext_AnyType = 1,
        CXCompletionContext_AnyValue = 2,
        CXCompletionContext_ObjCObjectValue = 4,
        CXCompletionContext_ObjCSelectorValue = 8,
        CXCompletionContext_CXXClassTypeValue = 16,
        CXCompletionContext_DotMemberAccess = 32,
        CXCompletionContext_ArrowMemberAccess = 64,
        CXCompletionContext_ObjCPropertyAccess = 128,
        CXCompletionContext_EnumTag = 256,
        CXCompletionContext_UnionTag = 512,
        CXCompletionContext_StructTag = 1024,
        CXCompletionContext_ClassTag = 2048,
        CXCompletionContext_Namespace = 4096,
        CXCompletionContext_NestedNameSpecifier = 8192,
        CXCompletionContext_ObjCInterface = 16384,
        CXCompletionContext_ObjCProtocol = 32768,
        CXCompletionContext_ObjCCategory = 65536,
        CXCompletionContext_ObjCInstanceMessage = 131072,
        CXCompletionContext_ObjCClassMessage = 262144,
        CXCompletionContext_ObjCSelectorName = 524288,
        CXCompletionContext_MacroName = 1048576,
        CXCompletionContext_NaturalLanguage = 2097152,
        CXCompletionContext_IncludedFile = 4194304,
        CXCompletionContext_Unknown = 8388607
    }

    // Enum @ Index.h:5995:9 (clang-c/Index.h)
    public enum CXEvalResultKind : int
    {
        CXEval_Int = 1,
        CXEval_Float = 2,
        CXEval_ObjCStrLiteral = 3,
        CXEval_StrLiteral = 4,
        CXEval_CFStr = 5,
        CXEval_Other = 6,
        CXEval_UnExposed = 0
    }

    // Enum @ Index.h:6138:6 (clang-c/Index.h)
    public enum CXVisitorResult : int
    {
        CXVisit_Break = 0,
        CXVisit_Continue = 1
    }

    // Enum @ Index.h:6145:9 (clang-c/Index.h)
    public enum CXResult : int
    {
        CXResult_Success = 0,
        CXResult_Invalid = 1,
        CXResult_VisitBreak = 2
    }

    // Enum @ Index.h:6290:9 (clang-c/Index.h)
    public enum CXIdxEntityKind : int
    {
        CXIdxEntity_Unexposed = 0,
        CXIdxEntity_Typedef = 1,
        CXIdxEntity_Function = 2,
        CXIdxEntity_Variable = 3,
        CXIdxEntity_Field = 4,
        CXIdxEntity_EnumConstant = 5,
        CXIdxEntity_ObjCClass = 6,
        CXIdxEntity_ObjCProtocol = 7,
        CXIdxEntity_ObjCCategory = 8,
        CXIdxEntity_ObjCInstanceMethod = 9,
        CXIdxEntity_ObjCClassMethod = 10,
        CXIdxEntity_ObjCProperty = 11,
        CXIdxEntity_ObjCIvar = 12,
        CXIdxEntity_Enum = 13,
        CXIdxEntity_Struct = 14,
        CXIdxEntity_Union = 15,
        CXIdxEntity_CXXClass = 16,
        CXIdxEntity_CXXNamespace = 17,
        CXIdxEntity_CXXNamespaceAlias = 18,
        CXIdxEntity_CXXStaticVariable = 19,
        CXIdxEntity_CXXStaticMethod = 20,
        CXIdxEntity_CXXInstanceMethod = 21,
        CXIdxEntity_CXXConstructor = 22,
        CXIdxEntity_CXXDestructor = 23,
        CXIdxEntity_CXXConversionFunction = 24,
        CXIdxEntity_CXXTypeAlias = 25,
        CXIdxEntity_CXXInterface = 26
    }

    // Enum @ Index.h:6325:9 (clang-c/Index.h)
    public enum CXIdxEntityLanguage : int
    {
        CXIdxEntityLang_None = 0,
        CXIdxEntityLang_C = 1,
        CXIdxEntityLang_ObjC = 2,
        CXIdxEntityLang_CXX = 3,
        CXIdxEntityLang_Swift = 4
    }

    // Enum @ Index.h:6343:9 (clang-c/Index.h)
    public enum CXIdxEntityCXXTemplateKind : int
    {
        CXIdxEntity_NonTemplate = 0,
        CXIdxEntity_Template = 1,
        CXIdxEntity_TemplatePartialSpecialization = 2,
        CXIdxEntity_TemplateSpecialization = 3
    }

    // Enum @ Index.h:6350:9 (clang-c/Index.h)
    public enum CXIdxAttrKind : int
    {
        CXIdxAttr_Unexposed = 0,
        CXIdxAttr_IBAction = 1,
        CXIdxAttr_IBOutlet = 2,
        CXIdxAttr_IBOutletCollection = 3
    }

    // Enum @ Index.h:6385:9 (clang-c/Index.h)
    public enum CXIdxDeclInfoFlags : int
    {
        CXIdxDeclFlag_Skipped = 1
    }

    // Enum @ Index.h:6413:9 (clang-c/Index.h)
    public enum CXIdxObjCContainerKind : int
    {
        CXIdxObjCContainer_ForwardRef = 0,
        CXIdxObjCContainer_Interface = 1,
        CXIdxObjCContainer_Implementation = 2
    }

    // Enum @ Index.h:6473:9 (clang-c/Index.h)
    public enum CXIdxEntityRefKind : int
    {
        CXIdxEntityRef_Direct = 1,
        CXIdxEntityRef_Implicit = 2
    }

    // Enum @ Index.h:6491:9 (clang-c/Index.h)
    public enum CXSymbolRole : int
    {
        CXSymbolRole_None = 0,
        CXSymbolRole_Declaration = 1,
        CXSymbolRole_Definition = 2,
        CXSymbolRole_Reference = 4,
        CXSymbolRole_Read = 8,
        CXSymbolRole_Write = 16,
        CXSymbolRole_Call = 32,
        CXSymbolRole_Dynamic = 64,
        CXSymbolRole_AddressOf = 128,
        CXSymbolRole_Implicit = 256
    }

    // Enum @ Index.h:6663:9 (clang-c/Index.h)
    public enum CXIndexOptFlags : int
    {
        CXIndexOpt_None = 0,
        CXIndexOpt_SuppressRedundantRefs = 1,
        CXIndexOpt_IndexFunctionLocalSymbols = 2,
        CXIndexOpt_IndexImplicitTemplateInstantiations = 4,
        CXIndexOpt_SuppressWarnings = 8,
        CXIndexOpt_SkipParsedBodiesInSession = 16
    }

    // MacroDefinition @ Index.h:35:9 (clang-c/Index.h)
    public const int CINDEX_VERSION_MAJOR = 0;

    // MacroDefinition @ Index.h:36:9 (clang-c/Index.h)
    public const int CINDEX_VERSION_MINOR = 62;
}