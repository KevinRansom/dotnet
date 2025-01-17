﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Razor.Workspaces;

namespace Microsoft.AspNetCore.Razor.LanguageServer;

internal class GeneratedDocumentSynchronizer(
    IGeneratedDocumentPublisher publisher,
    IDocumentVersionCache documentVersionCache,
    ProjectSnapshotManagerDispatcher dispatcher,
    LanguageServerFeatureOptions languageServerFeatureOptions) : DocumentProcessedListener
{
    private readonly IGeneratedDocumentPublisher _publisher = publisher;
    private readonly IDocumentVersionCache _documentVersionCache = documentVersionCache;
    private readonly ProjectSnapshotManagerDispatcher _dispatcher = dispatcher;
    private readonly LanguageServerFeatureOptions _languageServerFeatureOptions = languageServerFeatureOptions;

    public override void Initialize(IProjectSnapshotManager projectManager)
    {
    }

    public override void DocumentProcessed(RazorCodeDocument codeDocument, IDocumentSnapshot document)
    {
        _dispatcher.AssertRunningOnDispatcher();

        if (!_documentVersionCache.TryGetDocumentVersion(document, out var hostDocumentVersion))
        {
            // Could not resolve document version
            return;
        }

        var filePath = document.FilePath.AssumeNotNull();

        // If cohosting is on, then it is responsible for updating the Html buffer
        if (!_languageServerFeatureOptions.UseRazorCohostServer)
        {
            var htmlText = codeDocument.GetHtmlSourceText();

            _publisher.PublishHtml(document.Project.Key, filePath, htmlText, hostDocumentVersion.Value);
        }

        var csharpText = codeDocument.GetCSharpSourceText();

        _publisher.PublishCSharp(document.Project.Key, filePath, csharpText, hostDocumentVersion.Value);
    }
}
