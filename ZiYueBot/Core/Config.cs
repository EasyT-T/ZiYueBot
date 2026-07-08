namespace ZiYueBot.Core;

/// <summary>
/// Discord 及 MySQL 的相关配置。
/// 子悦机器初始化时会从根目录的 config.json 读取这些敏感信息。请勿公开 config.json。
/// 至于为什么必须是 MySQL，因为我服务器里有 MySQL。
/// </summary>
[Serializable]
public struct Config
{
    public string DiscordProxy { get; init; }
    public string DiscordToken { get; init; }
    public string DatabaseSource { get; init; }
    public int DatabasePort { get; init; }
    public string DatabaseName { get; init; }
    public string DatabaseUser { get; init; }
    public string DatabasePassword { get; init; }
    public string BailianApiEndpoint { get; init; }
    public string BailianApiKey { get; init; }
    public string QqEventEndpoint { get; init; }
    public string QqEventAuthenticate { get; init; }
    public string QqApiEndpoint { get; init; }
    public string QqApiAuthenticate { get; init; }
    public string AssetsEndpoint { get; init; }
    public string AssetsUploadRegion { get; init; }
    public string AssetsUploadBucket { get; init; }
    public string AssetsUploadSecretId { get; init; }
    public string AssetsUploadSecretKey { get; init; }
}