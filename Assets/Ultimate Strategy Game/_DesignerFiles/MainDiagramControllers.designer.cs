// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;


public abstract class ChunkControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public TerrainManagerController TerrainManagerController {get;set;}
    public abstract void InitializeChunk(ChunkViewModel chunk);
    
    public override ViewModel CreateEmpty() {
        return new ChunkViewModel(this);
    }
    
    public virtual ChunkViewModel CreateChunk() {
        return ((ChunkViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeChunk(((ChunkViewModel)(viewModel)));
    }
    
    public virtual void GenerateChunk(ChunkViewModel chunk) {
    }
    
    public virtual void UpdateChunk(ChunkViewModel chunk) {
    }
    
    public virtual void SaveChunkHexTexture(ChunkViewModel chunk) {
    }
}

public abstract class TerrainManagerControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public WorldManagerController WorldManagerController {get;set;}
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public ChunkController ChunkController {get;set;}
    public abstract void InitializeTerrainManager(TerrainManagerViewModel terrainManager);
    
    public override ViewModel CreateEmpty() {
        return new TerrainManagerViewModel(this);
    }
    
    public virtual TerrainManagerViewModel CreateTerrainManager() {
        return ((TerrainManagerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeTerrainManager(((TerrainManagerViewModel)(viewModel)));
    }
    
    public virtual void GenerateMap(TerrainManagerViewModel terrainManager) {
    }
    
    public virtual void GenerateChunks(TerrainManagerViewModel terrainManager) {
    }
    
    public virtual void GetHexAtWorldPos(TerrainManagerViewModel terrainManager, Vector3 arg) {
    }
}

public abstract class WorldManagerControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public TerrainManagerController TerrainManagerController {get;set;}
    public abstract void InitializeWorldManager(WorldManagerViewModel worldManager);
    
    public override ViewModel CreateEmpty() {
        return new WorldManagerViewModel(this);
    }
    
    public virtual WorldManagerViewModel CreateWorldManager() {
        return ((WorldManagerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeWorldManager(((WorldManagerViewModel)(viewModel)));
    }
}

public abstract class AStarControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    public abstract void InitializeAStar(AStarViewModel aStar);
    
    public override ViewModel CreateEmpty() {
        return new AStarViewModel(this);
    }
    
    public virtual AStarViewModel CreateAStar() {
        return ((AStarViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeAStar(((AStarViewModel)(viewModel)));
    }
}

public abstract class GameLogicControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public TerrainManagerController TerrainManagerController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    public abstract void InitializeGameLogic(GameLogicViewModel gameLogic);
    
    public override ViewModel CreateEmpty() {
        return new GameLogicViewModel(this);
    }
    
    public virtual GameLogicViewModel CreateGameLogic() {
        return ((GameLogicViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeGameLogic(((GameLogicViewModel)(viewModel)));
    }
    
    public virtual void StartGame(GameLogicViewModel gameLogic) {
    }
    
    public virtual void SetupPlayers(GameLogicViewModel gameLogic) {
    }
    
    public virtual void NextTurn(GameLogicViewModel gameLogic) {
    }
}

public abstract class PlayerControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    public abstract void InitializePlayer(PlayerViewModel player);
    
    public override ViewModel CreateEmpty() {
        return new PlayerViewModel(this);
    }
    
    public virtual PlayerViewModel CreatePlayer() {
        return ((PlayerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializePlayer(((PlayerViewModel)(viewModel)));
    }
    
    public virtual void SelectHex(PlayerViewModel player, Hex arg) {
    }
    
    public virtual void SelectHexAtPos(PlayerViewModel player, Vector3 arg) {
    }
    
    public virtual void SelectUnit(PlayerViewModel player, UnitViewModel arg) {
    }
    
    public virtual void MoveUnit(PlayerViewModel player, UnitViewModel arg) {
    }
}

public abstract class UnitControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    public abstract void InitializeUnit(UnitViewModel unit);
    
    public override ViewModel CreateEmpty() {
        return new UnitViewModel(this);
    }
    
    public virtual UnitViewModel CreateUnit() {
        return ((UnitViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeUnit(((UnitViewModel)(viewModel)));
    }
    
    public virtual void Move(UnitViewModel unit, Hex arg) {
    }
    
    public virtual void CancelMove(UnitViewModel unit) {
    }
    
    public virtual void WorldPosToHexLocation(UnitViewModel unit, Vector3 arg) {
    }
}

public abstract class FactionControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
    [Inject] public CityController CityController {get;set;}
    public abstract void InitializeFaction(FactionViewModel faction);
    
    public override ViewModel CreateEmpty() {
        return new FactionViewModel(this);
    }
    
    public virtual FactionViewModel CreateFaction() {
        return ((FactionViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFaction(((FactionViewModel)(viewModel)));
    }
}

public abstract class CityControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public BuildingController BuildingController {get;set;}
    public abstract void InitializeCity(CityViewModel city);
    
    public override ViewModel CreateEmpty() {
        return new CityViewModel(this);
    }
    
    public virtual CityViewModel CreateCity() {
        return ((CityViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeCity(((CityViewModel)(viewModel)));
    }
}

public abstract class BuildingControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public CityController CityController {get;set;}
    public abstract void InitializeBuilding(BuildingViewModel building);
    
    public override ViewModel CreateEmpty() {
        return new BuildingViewModel(this);
    }
    
    public virtual BuildingViewModel CreateBuilding() {
        return ((BuildingViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeBuilding(((BuildingViewModel)(viewModel)));
    }
}

public abstract class TerrainElementControllerBase : Controller {
    
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    public abstract void InitializeTerrainElement(TerrainElementViewModel terrainElement);
    
    public override ViewModel CreateEmpty() {
        return new TerrainElementViewModel(this);
    }
    
    public virtual TerrainElementViewModel CreateTerrainElement() {
        return ((TerrainElementViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeTerrainElement(((TerrainElementViewModel)(viewModel)));
    }
}

public abstract class AIPlayerControllerBase : PlayerController {
    
    public abstract void InitializeAIPlayer(AIPlayerViewModel aIPlayer);
    
    public override ViewModel CreateEmpty() {
        return new AIPlayerViewModel(this);
    }
    
    public virtual AIPlayerViewModel CreateAIPlayer() {
        return ((AIPlayerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeAIPlayer(((AIPlayerViewModel)(viewModel)));
    }
    
    public virtual void Think(AIPlayerViewModel aIPlayer) {
    }
}

public abstract class SettlerUnitControllerBase : UnitController {
    
    public abstract void InitializeSettlerUnit(SettlerUnitViewModel settlerUnit);
    
    public override ViewModel CreateEmpty() {
        return new SettlerUnitViewModel(this);
    }
    
    public virtual SettlerUnitViewModel CreateSettlerUnit() {
        return ((SettlerUnitViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeSettlerUnit(((SettlerUnitViewModel)(viewModel)));
    }
    
    public virtual void Settle(SettlerUnitViewModel settlerUnit) {
    }
}

public abstract class CombatUnitControllerBase : UnitController {
    
    public abstract void InitializeCombatUnit(CombatUnitViewModel combatUnit);
    
    public override ViewModel CreateEmpty() {
        return new CombatUnitViewModel(this);
    }
    
    public virtual CombatUnitViewModel CreateCombatUnit() {
        return ((CombatUnitViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeCombatUnit(((CombatUnitViewModel)(viewModel)));
    }
}
