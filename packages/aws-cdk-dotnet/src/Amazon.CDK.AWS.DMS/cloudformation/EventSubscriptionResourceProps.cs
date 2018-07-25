using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.DMS.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html </remarks>
    public class EventSubscriptionResourceProps : DeputyBase, IEventSubscriptionResourceProps
    {
        /// <summary>``AWS::DMS::EventSubscription.SnsTopicArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-snstopicarn </remarks>
        [JsiiProperty("snsTopicArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object SnsTopicArn
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.Enabled``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-enabled </remarks>
        [JsiiProperty("enabled", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.EventCategories``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-eventcategories </remarks>
        [JsiiProperty("eventCategories", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}", true)]
        public object EventCategories
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.SourceIds``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-sourceids </remarks>
        [JsiiProperty("sourceIds", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}", true)]
        public object SourceIds
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.SourceType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-sourcetype </remarks>
        [JsiiProperty("sourceType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object SourceType
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.SubscriptionName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-subscriptionname </remarks>
        [JsiiProperty("subscriptionName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object SubscriptionName
        {
            get;
            set;
        }

        /// <summary>``AWS::DMS::EventSubscription.Tags``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html#cfn-dms-eventsubscription-tags </remarks>
        [JsiiProperty("tags", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/cdk.Tag\"}]}}}}]},\"optional\":true}", true)]
        public object Tags
        {
            get;
            set;
        }
    }
}