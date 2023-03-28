﻿// guids.h: definitions of GUIDs/IIDs/CLSIDs used in this VsPackage

/*
Do not use #pragma once, as this file needs to be included twice.  Once to declare the externs
for the GUIDs, and again right after including initguid.h to actually define the GUIDs.
*/



// package guid
// { 3b336d5e-3d60-42d6-81f1-b0f26baec137 }
#define guidispcSyntaxPkg { 0x3B336D5E, 0x3D60, 0x42D6, { 0x81, 0xF1, 0xB0, 0xF2, 0x6B, 0xAE, 0xC1, 0x37 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_ispcSyntax,
0x3B336D5E, 0x3D60, 0x42D6, 0x81, 0xF1, 0xB0, 0xF2, 0x6B, 0xAE, 0xC1, 0x37 );
#endif

// Command set guid for our commands (used with IOleCommandTarget)
// { 106357d1-1e6d-4e38-98cf-4b266a9ef549 }
#define guidispcSyntaxCmdSet { 0x106357D1, 0x1E6D, 0x4E38, { 0x98, 0xCF, 0x4B, 0x26, 0x6A, 0x9E, 0xF5, 0x49 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_ispcSyntaxCmdSet, 
0x106357D1, 0x1E6D, 0x4E38, 0x98, 0xCF, 0x4B, 0x26, 0x6A, 0x9E, 0xF5, 0x49 );
#endif

//Guid for the image list referenced in the VSCT file
// { 4484e2df-a1f9-45f0-a281-f67feb213bf0 }
#define guidImages { 0x4484E2DF, 0xA1F9, 0x45F0, { 0xA2, 0x81, 0xF6, 0x7F, 0xEB, 0x21, 0x3B, 0xF0 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_Images, 
0x4484E2DF, 0xA1F9, 0x45F0, 0xA2, 0x81, 0xF6, 0x7F, 0xEB, 0x21, 0x3B, 0xF0 );
#endif


// Guid for the Editor Factory
// { 1988e01f-238e-496a-be04-642bd888cf1f }
#define guidispcSyntaxEditorFactory { 0x1988E01F, 0x238E, 0x496A, { 0xBE, 0x4, 0x64, 0x2B, 0xD8, 0x88, 0xCF, 0x1F } } 
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_ispcSyntaxEditorFactory, 
0x1988E01F, 0x238E, 0x496A, 0xBE, 0x4, 0x64, 0x2B, 0xD8, 0x88, 0xCF, 0x1F ); 
#endif

// Guid for the Editor Document (the document is the actual editor)
// { 0c3d2821-ac98-416f-9a44-925e7cb866ad }
#define guidispcSyntaxEditorDocument { 0xC3D2821, 0xAC98, 0x416F, { 0x9A, 0x44, 0x92, 0x5E, 0x7C, 0xB8, 0x66, 0xAD } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_ispcSyntaxEditorDocument, 
0xC3D2821, 0xAC98, 0x416F, 0x9A, 0x44, 0x92, 0x5E, 0x7C, 0xB8, 0x66, 0xAD );
#endif

