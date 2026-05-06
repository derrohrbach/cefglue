//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_chrome_page_action_icon_type_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Chrome page action icon types. Should be kept in sync with Chromium's
    /// PageActionIconType type.
    /// </summary>
    public enum CefChromePageActionIconType
    {
        BookmarkStar = 0,
        /// <summary>
        /// CEF_CPAIT_CLICK_TO_CALL_DEPRECATED in experimental builds (value 1),
        /// CEF_CPAIT_CLICK_TO_CALL in non-experimental builds (value 1).
        /// </summary>
        ClickToCall = 1,
        ClickToCallDeprecated = 1,
        CookieControls,
        FileSystemAccess,
        Find,
        MemorySaver,
        IntentPicker,
        LocalCardMigration,
        ManagePasswords,
        PaymentsOfferNotification,
        PriceTracking,
        PwaInstall,
        QrCodeGeneratorDeprecated,
        ReaderModeDeprecated,
        SaveAutofillAddress,
        SaveCard,
        SendTabToSelfDeprecated,
        SharingHub,
        SideSearchDeprecated,
        SmsRemoteFetcher,
        Translate,
        VirtualCardEnroll,
        VirtualCardInformation,
        Zoom,
        SaveIban,
        MandatoryReauth,
        PriceInsights,
        ReadAnythingDeprecated,
        ProductSpecifications,
        LensOverlay,
        Discounts,
        OptimizationGuide,
        CollaborationMessaging,
        ChangePassword,
        LensOverlayHomework,
        AiMode,
        ReadingMode,
        ContextualSidePanel,
        JsOptimizations,
        RecordReplay,
        Indigo,
        FederationDeprecated,
        Glic,
        NumValues,
    }
}
