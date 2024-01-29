{"payload":{"allShortcutsEnabled":true,"fileTree":{"Unity/Assets/Scripts/Runtime/RMC/Templates":{"items":[{"name":"ITemplateInterface.cs","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/ITemplateInterface.cs","contentType":"file"},{"name":"ITemplateInterface.cs.meta","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/ITemplateInterface.cs.meta","contentType":"file"},{"name":"TemplateClass.cs","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateClass.cs","contentType":"file"},{"name":"TemplateClass.cs.meta","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateClass.cs.meta","contentType":"file"},{"name":"TemplateComponent.cs","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs","contentType":"file"},{"name":"TemplateComponent.cs.meta","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs.meta","contentType":"file"},{"name":"TemplateScriptableObject.cs","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateScriptableObject.cs","contentType":"file"},{"name":"TemplateScriptableObject.cs.meta","path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateScriptableObject.cs.meta","contentType":"file"}],"totalCount":8},"Unity/Assets/Scripts/Runtime/RMC":{"items":[{"name":"Templates","path":"Unity/Assets/Scripts/Runtime/RMC/Templates","contentType":"directory"},{"name":"[MyProject]","path":"Unity/Assets/Scripts/Runtime/RMC/[MyProject]","contentType":"directory"},{"name":"RMC.MyProject.Runtime.asmdef","path":"Unity/Assets/Scripts/Runtime/RMC/RMC.MyProject.Runtime.asmdef","contentType":"file"},{"name":"RMC.MyProject.Runtime.asmdef.meta","path":"Unity/Assets/Scripts/Runtime/RMC/RMC.MyProject.Runtime.asmdef.meta","contentType":"file"},{"name":"Templates.meta","path":"Unity/Assets/Scripts/Runtime/RMC/Templates.meta","contentType":"file"},{"name":"[MyProject].meta","path":"Unity/Assets/Scripts/Runtime/RMC/[MyProject].meta","contentType":"file"}],"totalCount":6},"Unity/Assets/Scripts/Runtime":{"items":[{"name":"RMC","path":"Unity/Assets/Scripts/Runtime/RMC","contentType":"directory"},{"name":"RMC.meta","path":"Unity/Assets/Scripts/Runtime/RMC.meta","contentType":"file"}],"totalCount":2},"Unity/Assets/Scripts":{"items":[{"name":"Editor","path":"Unity/Assets/Scripts/Editor","contentType":"directory"},{"name":"Runtime","path":"Unity/Assets/Scripts/Runtime","contentType":"directory"},{"name":"Tests","path":"Unity/Assets/Scripts/Tests","contentType":"directory"},{"name":"Editor.meta","path":"Unity/Assets/Scripts/Editor.meta","contentType":"file"},{"name":"Runtime.meta","path":"Unity/Assets/Scripts/Runtime.meta","contentType":"file"},{"name":"Tests.meta","path":"Unity/Assets/Scripts/Tests.meta","contentType":"file"}],"totalCount":6},"Unity/Assets":{"items":[{"name":"3rdParty","path":"Unity/Assets/3rdParty","contentType":"directory"},{"name":"Art","path":"Unity/Assets/Art","contentType":"directory"},{"name":"Documentation","path":"Unity/Assets/Documentation","contentType":"directory"},{"name":"Prefabs","path":"Unity/Assets/Prefabs","contentType":"directory"},{"name":"Presets","path":"Unity/Assets/Presets","contentType":"directory"},{"name":"Resources","path":"Unity/Assets/Resources","contentType":"directory"},{"name":"Scenes","path":"Unity/Assets/Scenes","contentType":"directory"},{"name":"ScriptableObjects","path":"Unity/Assets/ScriptableObjects","contentType":"directory"},{"name":"Scripts","path":"Unity/Assets/Scripts","contentType":"directory"},{"name":"Settings","path":"Unity/Assets/Settings","contentType":"directory"},{"name":"3rdParty.meta","path":"Unity/Assets/3rdParty.meta","contentType":"file"},{"name":"Art.meta","path":"Unity/Assets/Art.meta","contentType":"file"},{"name":"Documentation.meta","path":"Unity/Assets/Documentation.meta","contentType":"file"},{"name":"Prefabs.meta","path":"Unity/Assets/Prefabs.meta","contentType":"file"},{"name":"Presets.meta","path":"Unity/Assets/Presets.meta","contentType":"file"},{"name":"Resources.meta","path":"Unity/Assets/Resources.meta","contentType":"file"},{"name":"Scenes.meta","path":"Unity/Assets/Scenes.meta","contentType":"file"},{"name":"ScriptableObjects.meta","path":"Unity/Assets/ScriptableObjects.meta","contentType":"file"},{"name":"Scripts.meta","path":"Unity/Assets/Scripts.meta","contentType":"file"},{"name":"Settings.meta","path":"Unity/Assets/Settings.meta","contentType":"file"}],"totalCount":20},"Unity":{"items":[{"name":"Assets","path":"Unity/Assets","contentType":"directory"},{"name":"Packages","path":"Unity/Packages","contentType":"directory"},{"name":"ProjectSettings","path":"Unity/ProjectSettings","contentType":"directory"}],"totalCount":3},"":{"items":[{"name":"Unity","path":"Unity","contentType":"directory"},{"name":".gitignore","path":".gitignore","contentType":"file"},{"name":"README.md","path":"README.md","contentType":"file"}],"totalCount":3}},"fileTreeProcessingTime":13.298466,"foldersToFetch":[],"reducedMotionEnabled":"system","repo":{"id":337545056,"defaultBranch":"master","name":"unity-project-template","ownerLogin":"SamuelAsherRivello","currentUserCanPush":false,"isFork":false,"isEmpty":false,"createdAt":"2021-02-10T01:16:03.000+03:30","ownerAvatar":"https://avatars.githubusercontent.com/u/63511769?v=4","public":true,"private":false,"isOrgOwned":false},"symbolsExpanded":false,"treeExpanded":true,"refInfo":{"name":"master","listCacheKey":"v0:1612909148.977159","canEdit":true,"refType":"branch","currentOid":"0041b1be9d38ebf3da6df2d53b8c7c7ba7dfa02b"},"path":"Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs","currentUser":{"id":29370234,"login":"Ario92","userEmail":"golkar.asghar@gmail.com"},"blob":{"rawLines":["using UnityEngine;","","namespace RMC.Templates","{","\t//  Namespace Properties ------------------------------","","","\t//  Class Attributes ----------------------------------","","","\t/// <summary>","\t/// Replace with comments...","\t/// </summary>","\tpublic class TemplateComponent : MonoBehaviour","\t{","\t\t//  Events ----------------------------------------","","","\t\t//  Properties ------------------------------------","\t\tpublic string SamplePublicText","\t\t{","\t\t\tget { return _samplePublicText; }","\t\t\tset { _samplePublicText = value; }","\t\t}","","","\t\t//  Fields ----------------------------------------","\t\t[SerializeField]","\t\tprivate string _samplePublicText;","","","\t\t//  Unity Methods ---------------------------------","\t\tprotected void Start()","\t\t{","","\t\t}","","","\t\tprotected void Update()","\t\t{","","\t\t}","","","\t\t//  Methods ---------------------------------------","\t\tpublic string SamplePublicMethod(string message)","\t\t{","\t\t\treturn message;","\t\t}","","","\t\t//  Event Handlers --------------------------------","\t\tpublic void Target_OnCompleted(string message)","\t\t{","","\t\t}","\t}","}"],"stylingDirectives":[[{"start":0,"end":5,"cssClass":"pl-k"},{"start":17,"end":18,"cssClass":"pl-kos"}],[],[{"start":0,"end":9,"cssClass":"pl-k"},{"start":13,"end":14,"cssClass":"pl-kos"}],[{"start":0,"end":1,"cssClass":"pl-kos"}],[{"start":1,"end":56,"cssClass":"pl-c"}],[],[],[{"start":1,"end":56,"cssClass":"pl-c"}],[],[],[{"start":1,"end":14,"cssClass":"pl-c"}],[{"start":1,"end":29,"cssClass":"pl-c"}],[{"start":1,"end":15,"cssClass":"pl-c"}],[{"start":1,"end":7,"cssClass":"pl-k"},{"start":8,"end":13,"cssClass":"pl-k"},{"start":14,"end":31,"cssClass":"pl-smi"},{"start":32,"end":33,"cssClass":"pl-c1"},{"start":34,"end":47,"cssClass":"pl-smi"}],[{"start":1,"end":2,"cssClass":"pl-kos"}],[{"start":2,"end":53,"cssClass":"pl-c"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":8,"cssClass":"pl-k"},{"start":9,"end":15,"cssClass":"pl-smi"},{"start":16,"end":32,"cssClass":"pl-s1"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[{"start":3,"end":6,"cssClass":"pl-k"},{"start":7,"end":8,"cssClass":"pl-kos"},{"start":9,"end":15,"cssClass":"pl-k"},{"start":16,"end":33,"cssClass":"pl-s1"},{"start":33,"end":34,"cssClass":"pl-kos"},{"start":35,"end":36,"cssClass":"pl-kos"}],[{"start":3,"end":6,"cssClass":"pl-k"},{"start":7,"end":8,"cssClass":"pl-kos"},{"start":9,"end":26,"cssClass":"pl-s1"},{"start":27,"end":28,"cssClass":"pl-c1"},{"start":29,"end":34,"cssClass":"pl-s1"},{"start":34,"end":35,"cssClass":"pl-kos"},{"start":36,"end":37,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":3,"cssClass":"pl-kos"},{"start":3,"end":17,"cssClass":"pl-c1"},{"start":17,"end":18,"cssClass":"pl-kos"}],[{"start":2,"end":9,"cssClass":"pl-k"},{"start":10,"end":16,"cssClass":"pl-smi"},{"start":17,"end":34,"cssClass":"pl-s1"},{"start":34,"end":35,"cssClass":"pl-kos"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":11,"cssClass":"pl-k"},{"start":12,"end":16,"cssClass":"pl-smi"},{"start":17,"end":22,"cssClass":"pl-en"},{"start":22,"end":23,"cssClass":"pl-kos"},{"start":23,"end":24,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[],[{"start":2,"end":11,"cssClass":"pl-k"},{"start":12,"end":16,"cssClass":"pl-smi"},{"start":17,"end":23,"cssClass":"pl-en"},{"start":23,"end":24,"cssClass":"pl-kos"},{"start":24,"end":25,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":8,"cssClass":"pl-k"},{"start":9,"end":15,"cssClass":"pl-smi"},{"start":16,"end":34,"cssClass":"pl-en"},{"start":34,"end":35,"cssClass":"pl-kos"},{"start":35,"end":41,"cssClass":"pl-smi"},{"start":42,"end":49,"cssClass":"pl-s1"},{"start":49,"end":50,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[{"start":3,"end":9,"cssClass":"pl-k"},{"start":10,"end":17,"cssClass":"pl-s1"},{"start":17,"end":18,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[],[{"start":2,"end":53,"cssClass":"pl-c"}],[{"start":2,"end":8,"cssClass":"pl-k"},{"start":9,"end":13,"cssClass":"pl-smi"},{"start":14,"end":32,"cssClass":"pl-en"},{"start":32,"end":33,"cssClass":"pl-kos"},{"start":33,"end":39,"cssClass":"pl-smi"},{"start":40,"end":47,"cssClass":"pl-s1"},{"start":47,"end":48,"cssClass":"pl-kos"}],[{"start":2,"end":3,"cssClass":"pl-kos"}],[],[{"start":2,"end":3,"cssClass":"pl-kos"}],[{"start":1,"end":2,"cssClass":"pl-kos"}],[{"start":0,"end":1,"cssClass":"pl-kos"}]],"csv":null,"csvError":null,"dependabotInfo":{"showConfigurationBanner":false,"configFilePath":null,"networkDependabotPath":"/SamuelAsherRivello/unity-project-template/network/updates","dismissConfigurationNoticePath":"/settings/dismiss-notice/dependabot_configuration_notice","configurationNoticeDismissed":false,"repoAlertsPath":"/SamuelAsherRivello/unity-project-template/security/dependabot","repoSecurityAndAnalysisPath":"/SamuelAsherRivello/unity-project-template/settings/security_analysis","repoOwnerIsOrg":false,"currentUserCanAdminRepo":false},"displayName":"TemplateComponent.cs","displayUrl":"https://github.com/SamuelAsherRivello/unity-project-template/blob/master/Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs?raw=true","headerInfo":{"blobSize":"993 Bytes","deleteInfo":{"deleteTooltip":"Fork this repository and delete the file"},"editInfo":{"editTooltip":"Fork this repository and edit the file"},"ghDesktopPath":"x-github-client://openRepo/https://github.com/SamuelAsherRivello/unity-project-template?branch=master&filepath=Unity%2FAssets%2FScripts%2FRuntime%2FRMC%2FTemplates%2FTemplateComponent.cs","gitLfsPath":null,"onBranch":true,"shortPath":"0a04a41","siteNavLoginPath":"/login?return_to=https%3A%2F%2Fgithub.com%2FSamuelAsherRivello%2Funity-project-template%2Fblob%2Fmaster%2FUnity%2FAssets%2FScripts%2FRuntime%2FRMC%2FTemplates%2FTemplateComponent.cs","isCSV":false,"isRichtext":false,"toc":null,"lineInfo":{"truncatedLoc":"58","truncatedSloc":"38"},"mode":"file"},"image":false,"isCodeownersFile":null,"isPlain":false,"isValidLegacyIssueTemplate":false,"issueTemplateHelpUrl":"https://docs.github.com/articles/about-issue-and-pull-request-templates","issueTemplate":null,"discussionTemplate":null,"language":"C#","languageID":42,"large":false,"loggedIn":true,"newDiscussionPath":"/SamuelAsherRivello/unity-project-template/discussions/new","newIssuePath":"/SamuelAsherRivello/unity-project-template/issues/new","planSupportInfo":{"repoIsFork":null,"repoOwnedByCurrentUser":null,"requestFullPath":"/SamuelAsherRivello/unity-project-template/blob/master/Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs","showFreeOrgGatedFeatureMessage":null,"showPlanSupportBanner":null,"upgradeDataAttributes":null,"upgradePath":null},"publishBannersInfo":{"dismissActionNoticePath":"/settings/dismiss-notice/publish_action_from_dockerfile","dismissStackNoticePath":"/settings/dismiss-notice/publish_stack_from_file","releasePath":"/SamuelAsherRivello/unity-project-template/releases/new?marketplace=true","showPublishActionBanner":false,"showPublishStackBanner":false},"rawBlobUrl":"https://github.com/SamuelAsherRivello/unity-project-template/raw/master/Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs","renderImageOrRaw":false,"richText":null,"renderedFileInfo":null,"shortPath":null,"tabSize":8,"topBannersInfo":{"overridingGlobalFundingFile":false,"globalPreferredFundingPath":null,"repoOwner":"SamuelAsherRivello","repoName":"unity-project-template","showInvalidCitationWarning":false,"citationHelpUrl":"https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/creating-a-repository-on-github/about-citation-files","showDependabotConfigurationBanner":false,"actionsOnboardingTip":null},"truncated":false,"viewable":true,"workflowRedirectUrl":null,"symbols":{"timed_out":false,"not_analyzed":false,"symbols":[{"name":"TemplateComponent","kind":"class","ident_start":239,"ident_end":256,"extent_start":226,"extent_end":990,"fully_qualified_name":"TemplateComponent","ident_utf16":{"start":{"line_number":13,"utf16_col":14},"end":{"line_number":13,"utf16_col":31}},"extent_utf16":{"start":{"line_number":13,"utf16_col":1},"end":{"line_number":56,"utf16_col":2}}},{"name":"SamplePublicText","kind":"field","ident_start":402,"ident_end":418,"extent_start":388,"extent_end":501,"fully_qualified_name":"TemplateComponent::SamplePublicText","ident_utf16":{"start":{"line_number":19,"utf16_col":16},"end":{"line_number":19,"utf16_col":32}},"extent_utf16":{"start":{"line_number":19,"utf16_col":2},"end":{"line_number":23,"utf16_col":3}}},{"name":"Start","kind":"method","ident_start":686,"ident_end":691,"extent_start":671,"extent_end":702,"fully_qualified_name":"TemplateComponent::Start","ident_utf16":{"start":{"line_number":32,"utf16_col":17},"end":{"line_number":32,"utf16_col":22}},"extent_utf16":{"start":{"line_number":32,"utf16_col":2},"end":{"line_number":35,"utf16_col":3}}},{"name":"Update","kind":"method","ident_start":722,"ident_end":728,"extent_start":707,"extent_end":739,"fully_qualified_name":"TemplateComponent::Update","ident_utf16":{"start":{"line_number":38,"utf16_col":17},"end":{"line_number":38,"utf16_col":23}},"extent_utf16":{"start":{"line_number":38,"utf16_col":2},"end":{"line_number":41,"utf16_col":3}}},{"name":"SamplePublicMethod","kind":"method","ident_start":812,"ident_end":830,"extent_start":798,"extent_end":873,"fully_qualified_name":"TemplateComponent::SamplePublicMethod","ident_utf16":{"start":{"line_number":45,"utf16_col":16},"end":{"line_number":45,"utf16_col":34}},"extent_utf16":{"start":{"line_number":45,"utf16_col":2},"end":{"line_number":48,"utf16_col":3}}},{"name":"Target_OnCompleted","kind":"method","ident_start":944,"ident_end":962,"extent_start":932,"extent_end":987,"fully_qualified_name":"TemplateComponent::Target_OnCompleted","ident_utf16":{"start":{"line_number":52,"utf16_col":14},"end":{"line_number":52,"utf16_col":32}},"extent_utf16":{"start":{"line_number":52,"utf16_col":2},"end":{"line_number":55,"utf16_col":3}}}]}},"copilotInfo":{"documentationUrl":"https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals","notices":{"codeViewPopover":{"dismissed":false,"dismissPath":"/settings/dismiss-notice/code_view_copilot_popover"}},"userAccess":{"accessAllowed":false,"hasSubscriptionEnded":false,"orgHasCFBAccess":false,"userHasCFIAccess":false,"userHasOrgs":false,"userIsOrgAdmin":false,"userIsOrgMember":false,"business":null,"featureRequestInfo":null}},"copilotAccessAllowed":false,"csrf_tokens":{"/SamuelAsherRivello/unity-project-template/branches":{"post":"vIlQl49a4KQulEq-FQ5k1bW9orBcHkntUFDWqC54pv0dNk_YvtYgXOpbc9cfnN83KXUUL2pKV2rdcvKLHzg1lg"},"/repos/preferences":{"post":"EeujvzPmHrjgdC5RJYM2XwV24TkFuwtt4fRWIBGSxjxBxwvyvqveDAJ5WvyussQH7TjcjXgXZ6zRZw4h1q8olg"}}},"title":"unity-project-template/Unity/Assets/Scripts/Runtime/RMC/Templates/TemplateComponent.cs at master · SamuelAsherRivello/unity-project-template"}