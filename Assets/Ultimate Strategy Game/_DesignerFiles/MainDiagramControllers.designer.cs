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
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
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
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public ChunkController ChunkController {get;set;}
    [Inject] public WorldManagerController WorldManagerController {get;set;}
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public FogOfWarController FogOfWarController {get;set;}
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
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
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

public abstract class GameLogicControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public TerrainManagerController TerrainManagerController {get;set;}
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
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
    [Inject] public CityController CityController {get;set;}
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
    
    public virtual void SelectUnitStack(PlayerViewModel player, UnitStackViewModel arg) {
    }
    
    public virtual void SelectCity(PlayerViewModel player, CityViewModel arg) {
    }
    
    public virtual void SetHoverUnitStack(PlayerViewModel player, UnitStackViewModel arg) {
    }
    
    public virtual void SetHoverCity(PlayerViewModel player, CityViewModel arg) {
    }
    
    public virtual void MoveUnitStack(PlayerViewModel player, UnitStackViewModel arg) {
    }
    
    public virtual void DeselectAll(PlayerViewModel player) {
    }
    
    public virtual void SelectUnit(PlayerViewModel player, UnitViewModel arg) {
    }
    
    public virtual void ShiftSelectUnit(PlayerViewModel player, UnitViewModel arg) {
    }
    
    public virtual void CtrlSelectUnit(PlayerViewModel player, UnitViewModel arg) {
    }
}

public abstract class UnitStackControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public FogOfWarController FogOfWarController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
    [Inject] public CityController CityController {get;set;}
    [Inject] public CharacterController CharacterController {get;set;}
    public abstract void InitializeUnitStack(UnitStackViewModel unitStack);
    
    public override ViewModel CreateEmpty() {
        return new UnitStackViewModel(this);
    }
    
    public virtual UnitStackViewModel CreateUnitStack() {
        return ((UnitStackViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeUnitStack(((UnitStackViewModel)(viewModel)));
    }
    
    public virtual void NextTurnCalculation(UnitStackViewModel unitStack) {
    }
    
    public virtual void AddUnit(UnitStackViewModel unitStack, UnitViewModel arg) {
    }
    
    public virtual void RemoveUnit(UnitStackViewModel unitStack, UnitViewModel arg) {
    }
    
    public virtual void PlanMovement(UnitStackViewModel unitStack) {
    }
    
    public virtual void PlanUnitDestination(UnitStackViewModel unitStack) {
    }
    
    public virtual void PlanSettling(UnitStackViewModel unitStack) {
    }
    
    public virtual void EvaluateMovementPath(UnitStackViewModel unitStack, Hex arg) {
    }
    
    public virtual void EvaluateSettlingLocation(UnitStackViewModel unitStack, Hex arg) {
    }
    
    public virtual void Move(UnitStackViewModel unitStack, Hex arg) {
    }
    
    public virtual void MoveSelectedUnits(UnitStackViewModel unitStack, Hex arg) {
    }
    
    public virtual void StopMove(UnitStackViewModel unitStack) {
    }
    
    public virtual void Settle(UnitStackViewModel unitStack) {
    }
    
    public virtual void FoundCity(UnitStackViewModel unitStack, Hex arg) {
    }
    
    public virtual void CancelAction(UnitStackViewModel unitStack) {
    }
    
    public virtual void PlanUnit(UnitStackViewModel unitStack) {
    }
    
    public virtual void DestroyStack(UnitStackViewModel unitStack) {
    }
    
    public virtual void Select(UnitStackViewModel unitStack) {
    }
    
    public virtual void Deselect(UnitStackViewModel unitStack) {
    }
    
    public virtual void PlanSelectedUnitsMovement(UnitStackViewModel unitStack) {
    }
}

public abstract class FactionControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public GameLogicController GameLogicController {get;set;}
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public FogOfWarController FogOfWarController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
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
    
    public virtual void NextTurnCalculation(FactionViewModel faction) {
    }
}

public abstract class CityControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public BuildingController BuildingController {get;set;}
    [Inject] public UnitController UnitController {get;set;}
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
    
    public virtual void NextTurnCalculation(CityViewModel city) {
    }
    
    public virtual void CalcPopulation(CityViewModel city) {
    }
    
    public virtual void CalcGoldIncome(CityViewModel city) {
    }
    
    public virtual void CalcHappieness(CityViewModel city) {
    }
    
    public virtual void CalcProduction(CityViewModel city) {
    }
    
    public virtual void CalcConstruction(CityViewModel city) {
    }
    
    public virtual void AddUnit(CityViewModel city, UnitViewModel arg) {
    }
    
    public virtual void RemovUnit(CityViewModel city, UnitViewModel arg) {
    }
}

public abstract class BuildingControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
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

public abstract class UnitControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public PlayerController PlayerController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    [Inject] public CityController CityController {get;set;}
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

public abstract class MeleeUnitControllerBase : UnitController {
    
    public abstract void InitializeMeleeUnit(MeleeUnitViewModel meleeUnit);
    
    public override ViewModel CreateEmpty() {
        return new MeleeUnitViewModel(this);
    }
    
    public virtual MeleeUnitViewModel CreateMeleeUnit() {
        return ((MeleeUnitViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeMeleeUnit(((MeleeUnitViewModel)(viewModel)));
    }
}

public abstract class CharacterControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public CharacterController CharacterController {get;set;}
    [Inject] public CharacterUnitController CharacterUnitController {get;set;}
    public abstract void InitializeCharacter(CharacterViewModel character);
    
    public override ViewModel CreateEmpty() {
        return new CharacterViewModel(this);
    }
    
    public virtual CharacterViewModel CreateCharacter() {
        return ((CharacterViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeCharacter(((CharacterViewModel)(viewModel)));
    }
}

public abstract class CharacterUnitControllerBase : UnitController {
    
    [Inject] public CharacterController CharacterController {get;set;}
    public abstract void InitializeCharacterUnit(CharacterUnitViewModel characterUnit);
    
    public override ViewModel CreateEmpty() {
        return new CharacterUnitViewModel(this);
    }
    
    public virtual CharacterUnitViewModel CreateCharacterUnit() {
        return ((CharacterUnitViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeCharacterUnit(((CharacterUnitViewModel)(viewModel)));
    }
}

public abstract class FogOfWarControllerBase : Controller {
    
    [Inject("FogOfWar")] public FogOfWarViewModel FogOfWar { get; set; }
    [Inject("TerrainManager")] public TerrainManagerViewModel TerrainManager { get; set; }
    [Inject("GameLogic")] public GameLogicViewModel GameLogic { get; set; }
    [Inject] public TerrainManagerController TerrainManagerController {get;set;}
    [Inject] public UnitStackController UnitStackController {get;set;}
    [Inject] public FactionController FactionController {get;set;}
    public abstract void InitializeFogOfWar(FogOfWarViewModel fogOfWar);
    
    public override ViewModel CreateEmpty() {
        return new FogOfWarViewModel(this);
    }
    
    public virtual FogOfWarViewModel CreateFogOfWar() {
        return ((FogOfWarViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFogOfWar(((FogOfWarViewModel)(viewModel)));
    }
    
    public virtual void UpdateFOW(FogOfWarViewModel fogOfWar) {
    }
    
    public virtual void UpdateUnitView(FogOfWarViewModel fogOfWar, UnitStackViewModel arg) {
    }
    
    public virtual void CalculateFOW(FogOfWarViewModel fogOfWar, FactionViewModel arg) {
    }
}
