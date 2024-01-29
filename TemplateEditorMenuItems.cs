{"payload":{"allShortcutsEnabled":true,"fileTree":{"Unity/Assets/Scripts/Editor/RMC/Templates":{"items":[{"name":"TemplateEditorMenuItems.cs","path":"Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs","contentType":"file"},{"name":"TemplateEditorMenuItems.cs.meta","path":"Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs.meta","contentType":"file"}],"totalCount":2},"Unity/Assets/Scripts/Editor/RMC":{"items":[{"name":"Templates","path":"Unity/Assets/Scripts/Editor/RMC/Templates","contentType":"directory"},{"name":"[MyProject]","path":"Unity/Assets/Scripts/Editor/RMC/[MyProject]","contentType":"directory"},{"name":"Templates.meta","path":"Unity/Assets/Scripts/Editor/RMC/Templates.meta","contentType":"file"},{"name":"[MyProject].meta","path":"Unity/Assets/Scripts/Editor/RMC/[MyProject].meta","contentType":"file"}],"totalCount":4},"Unity/Assets/Scripts/Editor":{"items":[{"name":"RMC","path":"Unity/Assets/Scripts/Editor/RMC","contentType":"directory"},{"name":"RMC.MyProject.Editor.asmdef","path":"Unity/Assets/Scripts/Editor/RMC.MyProject.Editor.asmdef","contentType":"file"},{"name":"RMC.MyProject.Editor.asmdef.meta","path":"Unity/Assets/Scripts/Editor/RMC.MyProject.Editor.asmdef.meta","contentType":"file"},{"name":"RMC.meta","path":"Unity/Assets/Scripts/Editor/RMC.meta","contentType":"file"}],"totalCount":4},"Unity/Assets/Scripts":{"items":[{"name":"Editor","path":"Unity/Assets/Scripts/Editor","contentType":"directory"},{"name":"Runtime","path":"Unity/Assets/Scripts/Runtime","contentType":"directory"},{"name":"Tests","path":"Unity/Assets/Scripts/Tests","contentType":"directory"},{"name":"Editor.meta","path":"Unity/Assets/Scripts/Editor.meta","contentType":"file"},{"name":"Runtime.meta","path":"Unity/Assets/Scripts/Runtime.meta","contentType":"file"},{"name":"Tests.meta","path":"Unity/Assets/Scripts/Tests.meta","contentType":"file"}],"totalCount":6},"Unity/Assets":{"items":[{"name":"3rdParty","path":"Unity/Assets/3rdParty","contentType":"directory"},{"name":"Art","path":"Unity/Assets/Art","contentType":"directory"},{"name":"Documentation","path":"Unity/Assets/Documentation","contentType":"directory"},{"name":"Prefabs","path":"Unity/Assets/Prefabs","contentType":"directory"},{"name":"Presets","path":"Unity/Assets/Presets","contentType":"directory"},{"name":"Resources","path":"Unity/Assets/Resources","contentType":"directory"},{"name":"Scenes","path":"Unity/Assets/Scenes","contentType":"directory"},{"name":"ScriptableObjects","path":"Unity/Assets/ScriptableObjects","contentType":"directory"},{"name":"Scripts","path":"Unity/Assets/Scripts","contentType":"directory"},{"name":"Settings","path":"Unity/Assets/Settings","contentType":"directory"},{"name":"3rdParty.meta","path":"Unity/Assets/3rdParty.meta","contentType":"file"},{"name":"Art.meta","path":"Unity/Assets/Art.meta","contentType":"file"},{"name":"Documentation.meta","path":"Unity/Assets/Documentation.meta","contentType":"file"},{"name":"Prefabs.meta","path":"Unity/Assets/Prefabs.meta","contentType":"file"},{"name":"Presets.meta","path":"Unity/Assets/Presets.meta","contentType":"file"},{"name":"Resources.meta","path":"Unity/Assets/Resources.meta","contentType":"file"},{"name":"Scenes.meta","path":"Unity/Assets/Scenes.meta","contentType":"file"},{"name":"ScriptableObjects.meta","path":"Unity/Assets/ScriptableObjects.meta","contentType":"file"},{"name":"Scripts.meta","path":"Unity/Assets/Scripts.meta","contentType":"file"},{"name":"Settings.meta","path":"Unity/Assets/Settings.meta","contentType":"file"}],"totalCount":20},"Unity":{"items":[{"name":"Assets","path":"Unity/Assets","contentType":"directory"},{"name":"Packages","path":"Unity/Packages","contentType":"directory"},{"name":"ProjectSettings","path":"Unity/ProjectSettings","contentType":"directory"}],"totalCount":3},"":{"items":[{"name":"Unity","path":"Unity","contentType":"directory"},{"name":".gitignore","path":".gitignore","contentType":"file"},{"name":"README.md","path":"README.md","contentType":"file"}],"totalCount":3}},"fileTreeProcessingTime":17.609174,"foldersToFetch":[],"reducedMotionEnabled":"system","repo":{"id":337545056,"defaultBranch":"master","name":"unity-project-template","ownerLogin":"SamuelAsherRivello","currentUserCanPush":false,"isFork":false,"isEmpty":false,"createdAt":"2021-02-10T01:16:03.000+03:30","ownerAvatar":"https://avatars.githubusercontent.com/u/63511769?v=4","public":true,"private":false,"isOrgOwned":false},"symbolsExpanded":false,"treeExpanded":true,"refInfo":{"name":"master","listCacheKey":"v0:1612909148.977159","canEdit":true,"refType":"branch","currentOid":"0041b1be9d38ebf3da6df2d53b8c7c7ba7dfa02b"},"path":"Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs","currentUser":{"id":29370234,"login":"Ario92","userEmail":"golkar.asghar@gmail.com"},"blob":{"rawLines":["using UnityEditor;","using UnityEngine;","","namespace RMC.Templates","{","\t//  Namespace Properties ------------------------------","","\t//  Class Attributes ----------------------------------","","\t/// <summary>","\t/// Replace with comments...","\t/// </summary>","\tpublic class TemplateEditorMenuItems","\t{","\t\t//  Events ----------------------------------------","","","\t\t//  Properties ------------------------------------","","","\t\t//  Fields ----------------------------------------","\t\tprivate const string MenuItemName01 = \"Window/\" + CompanyName + \"/\" + ProjectName + \"/\" + \"SampleMenuItem\";","\t\tprivate const string CompanyName = \"RMC\";","\t\tprivate const string ProjectName = \"[MyProject]\";","","\t\t//  Unity Methods ---------------------------------","","","\t\t//  Methods ---------------------------------------","\t\t// [MenuItem(MenuItemName01, false, 0)]","\t\t// public static void SampleMenuItem()","\t\t// {","\t\t// \tDebug.Log(\"SampleMenuItem()\");","\t\t// }","","\t\t// [MenuItem(MenuItemName01, true, 0)]","\t\t// public static bool SampleMenuItem_Validate()","\t\t// {","\t\t// \treturn true; //return false to grey-out the menu item","\t\t// }","","\t\t//  Event Handlers --------------------------------","\t}","}"],"stylingDirectives":[[{"start":0,"end":5,"cssClass":"pl-k"},{"start":17,"end":18,"cssClass":"pl-kos"}],[{"start":0,"end":5,"cssClass":"pl-k"},{"start":17,"end":18,"cssClass":"pl-kos"}],[],[{"start":0,"end":9,"cssClass":"pl-k"},{"start":13,"end":14,"cssClass":"pl-kos"}],[{"start":0,"end":1,"cssClass":"pl-kos"}],[{"start":1,"end":56,"cssClass":"pl-c"}],[],[{"start":1,"end":56,"cssClass":"pl-c"}],[],[{"start":1,"end":14,"cssClass":"pl-c"}],[{"start":1,"end":29,"cssClass":"pl-c"}],[{"start":1,"end":15,"cssClass":"pl-c"}],[{"start":1,"end":7,"cssClass":"pl-k"},{"start":8,"end":13,"cssClass":"pl-k"},{"start":14,"end":37,"cssClass":"pl-smi"}],[{"start":1,"end":2,"cssClass":"pl-kos"}],[{"start":2,"end":53,"cssClass":"pl-c"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":9,"cssClass":"pl-k"},{"start":10,"end":15,"cssClass":"pl-k"},{"start":16,"end":22,"cssClass":"pl-smi"},{"start":23,"end":37,"cssClass":"pl-s1"},{"start":38,"end":39,"cssClass":"pl-c1"},{"start":40,"end":49,"cssClass":"pl-s"},{"start":40,"end":41,"cssClass":"pl-s"},{"start":48,"end":49,"cssClass":"pl-s"},{"start":50,"end":51,"cssClass":"pl-c1"},{"start":52,"end":63,"cssClass":"pl-s1"},{"start":64,"end":65,"cssClass":"pl-c1"},{"start":66,"end":69,"cssClass":"pl-s"},{"start":66,"end":67,"cssClass":"pl-s"},{"start":68,"end":69,"cssClass":"pl-s"},{"start":70,"end":71,"cssClass":"pl-c1"},{"start":72,"end":83,"cssClass":"pl-s1"},{"start":84,"end":85,"cssClass":"pl-c1"},{"start":86,"end":89,"cssClass":"pl-s"},{"start":86,"end":87,"cssClass":"pl-s"},{"start":88,"end":89,"cssClass":"pl-s"},{"start":90,"end":91,"cssClass":"pl-c1"},{"start":92,"end":108,"cssClass":"pl-s"},{"start":92,"end":93,"cssClass":"pl-s"},{"start":107,"end":108,"cssClass":"pl-s"},{"start":108,"end":109,"cssClass":"pl-kos"}],[{"start":2,"end":9,"cssClass":"pl-k"},{"start":10,"end":15,"cssClass":"pl-k"},{"start":16,"end":22,"cssClass":"pl-smi"},{"start":23,"end":34,"cssClass":"pl-s1"},{"start":35,"end":36,"cssClass":"pl-c1"},{"start":37,"end":42,"cssClass":"pl-s"},{"start":37,"end":38,"cssClass":"pl-s"},{"start":41,"end":42,"cssClass":"pl-s"},{"start":42,"end":43,"cssClass":"pl-kos"}],[{"start":2,"end":9,"cssClass":"pl-k"},{"start":10,"end":15,"cssClass":"pl-k"},{"start":16,"end":22,"cssClass":"pl-smi"},{"start":23,"end":34,"cssClass":"pl-s1"},{"start":35,"end":36,"cssClass":"pl-c1"},{"start":37,"end":50,"cssClass":"pl-s"},{"start":37,"end":38,"cssClass":"pl-s"},{"start":49,"end":50,"cssClass":"pl-s"},{"start":50,"end":51,"cssClass":"pl-kos"}],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":41,"cssClass":"pl-c"}],[{"start":2,"end":40,"cssClass":"pl-c"}],[{"start":2,"end":6,"cssClass":"pl-c"}],[{"start":2,"end":36,"cssClass":"pl-c"}],[{"start":2,"end":6,"cssClass":"pl-c"}],[],[{"start":2,"end":40,"cssClass":"pl-c"}],[{"start":2,"end":49,"cssClass":"pl-c"}],[{"start":2,"end":6,"cssClass":"pl-c"}],[{"start":2,"end":59,"cssClass":"pl-c"}],[{"start":2,"end":6,"cssClass":"pl-c"}],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":1,"end":2,"cssClass":"pl-kos"}],[{"start":0,"end":1,"cssClass":"pl-kos"}]],"csv":null,"csvError":null,"dependabotInfo":{"showConfigurationBanner":false,"configFilePath":null,"networkDependabotPath":"/SamuelAsherRivello/unity-project-template/network/updates","dismissConfigurationNoticePath":"/settings/dismiss-notice/dependabot_configuration_notice","configurationNoticeDismissed":false,"repoAlertsPath":"/SamuelAsherRivello/unity-project-template/security/dependabot","repoSecurityAndAnalysisPath":"/SamuelAsherRivello/unity-project-template/settings/security_analysis","repoOwnerIsOrg":false,"currentUserCanAdminRepo":false},"displayName":"TemplateEditorMenuItems.cs","displayUrl":"https://github.com/SamuelAsherRivello/unity-project-template/blob/master/Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs?raw=true","headerInfo":{"blobSize":"1.1 KB","deleteInfo":{"deleteTooltip":"Fork this repository and delete the file"},"editInfo":{"editTooltip":"Fork this repository and edit the file"},"ghDesktopPath":"x-github-client://openRepo/https://github.com/SamuelAsherRivello/unity-project-template?branch=master&filepath=Unity%2FAssets%2FScripts%2FEditor%2FRMC%2FTemplates%2FTemplateEditorMenuItems.cs","gitLfsPath":null,"onBranch":true,"shortPath":"8fd8ba4","siteNavLoginPath":"/login?return_to=https%3A%2F%2Fgithub.com%2FSamuelAsherRivello%2Funity-project-template%2Fblob%2Fmaster%2FUnity%2FAssets%2FScripts%2FEditor%2FRMC%2FTemplates%2FTemplateEditorMenuItems.cs","isCSV":false,"isRichtext":false,"toc":null,"lineInfo":{"truncatedLoc":"44","truncatedSloc":"32"},"mode":"file"},"image":false,"isCodeownersFile":null,"isPlain":false,"isValidLegacyIssueTemplate":false,"issueTemplateHelpUrl":"https://docs.github.com/articles/about-issue-and-pull-request-templates","issueTemplate":null,"discussionTemplate":null,"language":"C#","languageID":42,"large":false,"loggedIn":true,"newDiscussionPath":"/SamuelAsherRivello/unity-project-template/discussions/new","newIssuePath":"/SamuelAsherRivello/unity-project-template/issues/new","planSupportInfo":{"repoIsFork":null,"repoOwnedByCurrentUser":null,"requestFullPath":"/SamuelAsherRivello/unity-project-template/blob/master/Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs","showFreeOrgGatedFeatureMessage":null,"showPlanSupportBanner":null,"upgradeDataAttributes":null,"upgradePath":null},"publishBannersInfo":{"dismissActionNoticePath":"/settings/dismiss-notice/publish_action_from_dockerfile","dismissStackNoticePath":"/settings/dismiss-notice/publish_stack_from_file","releasePath":"/SamuelAsherRivello/unity-project-template/releases/new?marketplace=true","showPublishActionBanner":false,"showPublishStackBanner":false},"rawBlobUrl":"https://github.com/SamuelAsherRivello/unity-project-template/raw/master/Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs","renderImageOrRaw":false,"richText":null,"renderedFileInfo":null,"shortPath":null,"tabSize":8,"topBannersInfo":{"overridingGlobalFundingFile":false,"globalPreferredFundingPath":null,"repoOwner":"SamuelAsherRivello","repoName":"unity-project-template","showInvalidCitationWarning":false,"citationHelpUrl":"https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/creating-a-repository-on-github/about-citation-files","showDependabotConfigurationBanner":false,"actionsOnboardingTip":null},"truncated":false,"viewable":true,"workflowRedirectUrl":null,"symbols":{"timed_out":false,"not_analyzed":false,"symbols":[{"name":"TemplateEditorMenuItems","kind":"class","ident_start":256,"ident_end":279,"extent_start":243,"extent_end":1123,"fully_qualified_name":"TemplateEditorMenuItems","ident_utf16":{"start":{"line_number":12,"utf16_col":14},"end":{"line_number":12,"utf16_col":37}},"extent_utf16":{"start":{"line_number":12,"utf16_col":1},"end":{"line_number":42,"utf16_col":2}}}]}},"copilotInfo":{"documentationUrl":"https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals","notices":{"codeViewPopover":{"dismissed":false,"dismissPath":"/settings/dismiss-notice/code_view_copilot_popover"}},"userAccess":{"accessAllowed":false,"hasSubscriptionEnded":false,"orgHasCFBAccess":false,"userHasCFIAccess":false,"userHasOrgs":false,"userIsOrgAdmin":false,"userIsOrgMember":false,"business":null,"featureRequestInfo":null}},"copilotAccessAllowed":false,"csrf_tokens":{"/SamuelAsherRivello/unity-project-template/branches":{"post":"iDnGQlpNNE6CNM4qO-IpFc6lhwOfNtorBUR6KDLEe10phtkNa8H0tkb790MxcJL3Um0xnKlixKyIZl4LA4ToNg"},"/repos/preferences":{"post":"iJzxiMH5oh5iT_TrPWigk1MGwUrvy-HQMKngQMoFJQ7YsFnFTLRiqoBCgEa2WVLLu0j8_pJnjREAOrhBDTjLpA"}}},"title":"unity-project-template/Unity/Assets/Scripts/Editor/RMC/Templates/TemplateEditorMenuItems.cs at master · SamuelAsherRivello/unity-project-template"}