namespace Hidistro.Entities.Store
{
	public enum Privilege
	{
		Summary = 1000,
		SiteSettings,
		EmailSettings,
		SMSSettings,
		PaymentModes,
		ShippingTemplets = 1006,
		ExpressComputerpes,
		MessageTemplets,
		PictureMange,
		WeiXinTemplatesSet,
		MobbilePaySet,
		RegisterSetting,
		AreaManage,
		DadaSetting,
		Themes = 2001,
		Affiches,
		HelpCategories,
		Helps,
		ArticleCategories,
		Articles,
		FriendlyLinks,
		HotKeywords,
		EditeThems = 2010,
		SetHeaderMenu,
		SetWapCTemplates,
		DefineTopics,
		WapThemeSettings,
		Products = 3001,
		AddProducts,
		EditProducts,
		DeleteProducts,
		InStockProduct,
		UpShelfProducts,
		OffShelfProducts,
		ProductUnclassified = 3010,
		SubjectProducts,
		ProductBatchUpload,
		ProductTypes = 3017,
		AddProductType,
		EditProductType,
		DeleteProductType,
		ProductCategory,
		AddProductCategory,
		EditProductCategory,
		DeleteProductCategory,
		BrandCategories,
		ProductBatchExport,
		TopicManager,
		TopicAdd,
		TopicEdit,
		TopicDelete,
		SyncTaobao,
		Orders = 4001,
		DeleteOrder,
		EditOrders,
		CofimOrderPay,
		OrderSendGoods,
		ExpressPrint,
		RefundOrder,
		RemarkOrder,
		ExpressTemplates,
		Shippers,
		OrderLookup,
		OrderRefundApply,
		OrderReplaceApply,
		OrderReturnsApply,
		ConfirmTake,
		ManageDebitNote,
		ManageRefundNote,
		ManageSendNote,
		ManageReturnNote,
		AddExpressTemplate,
		AddShipper,
		SetOrderOption,
		CustomPrintItem,
		SetSynJDParam,
		SetSynJDOrder,
		ProductConsultationsManage = 7001,
		ProductReviewsManage,
		ReceivedMessages,
		SendedMessages,
		AddMessage,
		ManageLeaveComments,
		Members = 5001,
		EditMember,
		DeleteMember,
		MemberGrades,
		AddMemberGrade,
		EditMemberGrade,
		DeleteMemberGrade,
		OpenIdServices,
		OpenIdSettings,
		MemberBalanceStatistics,
		MemberDrawRequestStatistics,
		UpdateMemberPoint,
		MemberChart,
		MemberTags,
		VServerConfig = 6001,
		VReplyOnKey,
		VManageMenu,
		VShopTempEdit,
		VShopMenu,
		VManageLotteryActivity,
		VManageActivity,
		VManageLotteryTicket,
		VManageRedEnvelope,
		FightGroupManage = 6013,
		AppletProductSetting = 17001,
		AppletPayConfig,
		AppletMessageTemplate,
		AppletTempEdit,
		O2OAppletPayConfig = 17002,
		O2OAppletMessageTemplate,
		Gifts = 8001,
		ProductPromotion,
		OrderPromotion,
		BindProduct,
		GroupBuy,
		CountDown,
		Coupons,
		RegisterSendCoupons,
		SetSEO,
		SiteMap,
		CombinationBuy,
		ProductPreSale = 8015,
		AppDownloadCoupons,
		RechargeGift,
		Votes,
		MemberAccount = 9001,
		MemberReCharge,
		BalanceDrawRequest,
		TransactionAnalysis = 10010,
		TrafficStatistics,
		ProductAnalysis,
		MembertAnalysis,
		WachaWeChatFanGrowthAnalysis,
		WeChatFansInteractiveAnalysis,
		WapShopTempEdit = 11001,
		WapShopMenu,
		AliohShopTempEdit = 12001,
		AliohShopMenu,
		AliohServerConfig,
		AliohManageMenu,
		AliohAliPaySet,
		AliohShengPaySet,
		AliohOffLinePaySet,
		AppManageAppBanner = 13001,
		AppManageAppNavigate,
		AppProductSetting,
		AppManagerHomeTopic,
		AppAndroidUpgrade,
		AppIosUpgrade,
		AppAliPaySet,
		AppWeixinPay,
		AppShengPaySet,
		AppOffLinePaySet = 130010,
		AppBankUnionSet,
		AppStartPageSet,
		AppLotteryDrawSet,
		AppPushSet,
		AppPushRecords,
		AppHomePageEdit,
		StoreSetting = 14001,
		StoresList,
		AddStores,
		StoreBalance,
		SendGoodOrders,
		IbeaconEquipmentList,
		IbeaconPageList,
		IbeaconEffectStatic,
		HIPOSSetting,
		HIPOSBind,
		HIPOSDeal,
		StoreBalanceDetail,
		StoreAppDownLoad,
		MarketingImageList,
		MarktingList,
		TagList,
		StoreAppPushSet,
		ReferralRequest = 15001,
		Referrals,
		DeductSettings,
		ReferralSettings,
		SplittinDrawRequest,
		SplittinDrawRecord,
		ReferralGrades,
		AddReferralGrade,
		EditReferralGrade,
		DeleteReferralGrade,
		SupplierList = 16001,
		AddSupplier,
		EditSupplier,
		SupplierDetails,
		SupplierAuditPdList = 16100,
		SupplierPdList,
		SupplierAudit,
		SupplierEditPd,
		SupplierOrderList = 16200,
		SupplierRefund,
		SupplierReturns,
		SupplierReplace,
		SupplierBalance = 16300,
		SupplierDrawList,
		SupplierBalanceOrder,
		SupplierBalanceDetail
	}
}
